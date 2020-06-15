﻿using BusinessObjects.Models;
using BusinessObjects.Repositorys;
using BusinessObjects.Supports;
using DataAccessLayer;
using log4net;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PushSMS
{
    public partial class PushSMS : Form
    {
        private readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private RabbitHelper rabbitHelper;
        private OracleConnection connection;
        private OracleDependency oracleDependency;
        private Timer timer;

        private long SMS_COUNT = 0;

        public PushSMS()
        {
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            txtOracleConnection.Text = AppConfig.ORACLE_CONNECTION;
            txtRabbitConnection.Text = AppConfig.RABBIT_CONNECTION;
            lblCount.Text = this.SMS_COUNT.ToString();
            txtLimitLog.Text = "200";
            cbbCountSMS.SelectedIndex = 3;
            cbbMode.SelectedIndex = 0;
            cbbInterval.SelectedIndex = 1;
            cbbSmsType.SelectedIndex = 0;
            cbbSmsType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMode.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtOracleConnection.Text))
                {
                    MessageBox.Show("Nhập chuỗi kết nối database!", "Thông báo");
                    return;
                }

                if (String.IsNullOrEmpty(cbbCountSMS.Text))
                {
                    MessageBox.Show("Nhập số lượng SMS trên 1 truy vấn!", "Thông báo");
                    return;
                }

                if (String.IsNullOrEmpty(txtRabbitConnection.Text))
                {
                    MessageBox.Show("Nhập chuỗi kết nối queue!", "Thông báo");
                    return;
                }

                if (String.IsNullOrEmpty(txtLimitLog.Text))
                {
                    MessageBox.Show("Giới hạn log không đúng", "Thông báo");
                    return;
                }

                SetTextMonitor("Push SMS to Queue start!", Color.Aqua);
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                txtOracleConnection.Enabled = false;
                txtRabbitConnection.Enabled = false;
                cbbSmsType.Enabled = false;
                cbbCountSMS.Enabled = false;
                cbbMode.Enabled = false;
                cbbInterval.Enabled = false;
                txtLimitLog.Enabled = false;

                this.rabbitHelper = new RabbitHelper();
                this.rabbitHelper.Initialize();

                if (cbbMode.SelectedIndex == 0)
                {
                    this.connection = new OracleConnection(txtOracleConnection.Text);

                    using (OracleCommand command = new OracleCommand((cbbSmsType.SelectedIndex == 0) ? AppConfig.QUERY_SELECT_SMS : AppConfig.QUERY_SELECT_CAMPAIGN, this.connection) { AddRowid = true })
                    {
                        connection.Open();
                        this.oracleDependency = new OracleDependency(command, false, 0, false);
                        this.oracleDependency.OnChange += new OnChangeEventHandler(OracleListenerCallback);
                        command.ExecuteNonQuery();
                        SetTextMonitor("Push SMS to Queue listener started!", Color.Aqua);
                    }

                    PushSMSToQueue();
                }
                else
                {
                    if (String.IsNullOrEmpty(cbbInterval.Text))
                    {
                        MessageBox.Show("Nhập interval!", "Thông báo");
                        return;
                    }

                    this.timer = new Timer();
                    this.timer.Interval = Convert.ToInt32(cbbInterval.Text);
                    this.timer.Tick += new EventHandler(TimerIntervalCallback);
                    this.timer.Start();
                    SetTextMonitor("Push SMS to Queue timer started!", Color.Aqua);
                }
            }
            catch (Exception ex)
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                if (this.oracleDependency != null) this.oracleDependency.OnChange -= new OnChangeEventHandler(OracleListenerCallback);
                SetTextMonitor("BtnStart_Click " + ex.ToString(), Color.Red);
                logger.Error("BtnStart_Click", ex);
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbMode.SelectedIndex == 1)
                {
                    this.timer?.Stop();
                    this.timer?.Dispose();
                    this.timer.Tick -= new EventHandler(TimerIntervalCallback);
                    SetTextMonitor("Push SMS to Queue timer stoped!", Color.Aqua);
                }

                if (this.oracleDependency != null && this.oracleDependency.IsEnabled)
                {
                    this.oracleDependency.RemoveRegistration(this.connection);
                    this.oracleDependency.OnChange -= new OnChangeEventHandler(OracleListenerCallback);
                    this.connection.Close();
                    this.connection.Dispose();
                    this.oracleDependency = null;
                    SetTextMonitor("Push SMS to Queue listener stoped!", Color.Aqua);
                }

                this.SMS_COUNT = 0;

                btnStop.Enabled = false;
                btnStart.Enabled = true;
                txtOracleConnection.Enabled = true;
                txtRabbitConnection.Enabled = true;
                cbbSmsType.Enabled = true;
                cbbCountSMS.Enabled = true;
                cbbMode.Enabled = true;
                cbbInterval.Enabled = true;
                txtLimitLog.Enabled = true;
            }
            catch (Exception ex)
            {
                SetTextMonitor(ex.ToString(), Color.Red);
            }
        }

        private void TimerIntervalCallback(object sender, EventArgs args)
        {
            PushSMSToQueue();
        }

        private void OracleListenerCallback(object sender, OracleNotificationEventArgs events)
        {
            logger.Info(AppConst.A("OracleListenerCallback Event", events.Info.ToString()));
            if (events.Info == OracleNotificationInfo.Insert || events.Info == OracleNotificationInfo.Update)
                PushSMSToQueue();
        }

        private async void PushSMSToQueue()
        {
            try
            {
                IList<SmsModel> listSMS = await (new SmsRepository()).GetSmsListAsync(Convert.ToInt32(cbbCountSMS.Text), cbbSmsType.Text);
                List<SmsModel> listSuccess = new List<SmsModel>();
                List<SmsModel> listFail = new List<SmsModel>();

                if (listSMS != null && listSMS.Count > 0)
                {
                    IDictionary<string, IList<SmsModel>> dict = new Dictionary<string, IList<SmsModel>>();
                    (new SmsRepository()).UpdateStatusSMS(listSMS);

                    foreach (SmsModel sms in listSMS)
                    {
                        SmsModel detail = new SmsModel();
                        detail.ACCOUNT_ID = sms.ACCOUNT_ID;
                        detail.CAMPAIGN_ID = sms.CAMPAIGN_ID;
                        detail.COUNT_RETRY = sms.COUNT_RETRY;
                        detail.DLVR = sms.DLVR;
                        detail.ERR_CODE = sms.ERR_CODE;
                        detail.ERR_CODE_PARTNER = sms.ERR_CODE_PARTNER;
                        detail.HTTP_ENCODE_CSKH = sms.HTTP_ENCODE_CSKH;
                        detail.HTTP_ENCODE_QC = sms.HTTP_ENCODE_QC;
                        detail.HTTP_PASS_CSKH = sms.HTTP_PASS_CSKH;
                        detail.HTTP_PASS_QC = sms.HTTP_PASS_QC;
                        detail.HTTP_USER_CSKH = sms.HTTP_USER_CSKH;
                        detail.HTTP_USER_QC = sms.HTTP_USER_QC;
                        detail.ID = sms.ID;
                        detail.IS_UNICODE = sms.IS_UNICODE;
                        detail.PARTNER_NAME = sms.PARTNER_NAME;
                        detail.PHONE = sms.PHONE;
                        detail.RECEIVE_RESULT = sms.RECEIVE_RESULT;
                        detail.SCHEDULE_TIME = sms.SCHEDULE_TIME;
                        detail.SENDBY = sms.SENDBY;
                        detail.SENDER_NAME = sms.SENDER_NAME;
                        detail.SMPP_IP_1 = sms.SMPP_IP_1;
                        detail.SMPP_IP_2 = sms.SMPP_IP_2;
                        detail.SMPP_PASS = sms.SMPP_PASS;
                        detail.SMPP_PORT_1 = sms.SMPP_PORT_1;
                        detail.SMPP_PORT_2 = sms.SMPP_PORT_2;
                        detail.SMPP_USER = sms.SMPP_USER;
                        detail.SMS_CONTENT = sms.SMS_CONTENT;
                        detail.SMS_COUNT = sms.SMS_COUNT;
                        detail.SMS_TYPE = sms.SMS_TYPE;
                        detail.TELCO = sms.TELCO;
                        detail.URL_HTTP_1_CSKH = sms.URL_HTTP_1_CSKH;
                        detail.URL_HTTP_1_QC = sms.URL_HTTP_1_QC;
                        detail.URL_HTTP_2_CSKH = sms.URL_HTTP_2_CSKH;
                        detail.URL_HTTP_2_QC = sms.URL_HTTP_2_QC;
                        detail.URL_HTTP_3_CSKH = sms.URL_HTTP_3_CSKH;
                        detail.URL_HTTP_3_QC = sms.URL_HTTP_3_QC;
                        detail.VIA = sms.VIA;

                        // check loop sms
                        string sendTime = RedisHelper.Get(string.Format("PARTNER_CHECK_LOOP:{0},{1},{2},{3},{4}", sms.ACCOUNT_ID, sms.SENDER_NAME, sms.PHONE, sms.SMS_CONTENT, sms.TELCO));
                        if ((!string.IsNullOrEmpty(sendTime) && Convert.ToDateTime(sms.SCHEDULE_TIME).AddMinutes(-Convert.ToDouble(AppConfig.TIME_CHECK_LOOP)) > Convert.ToDateTime(sendTime)) || string.IsNullOrEmpty(sendTime))
                        {
                            listSuccess.Add(detail);
                        }
                        else
                        {
                            listFail.Add(detail);
                        }
                    }

                    // update status sms loop
                    if(listFail.Count > 0)
                        (new SmsRepository()).UpdateStatusSMSLoop(listFail);

                    // push to queue
                    foreach (SmsModel sms in listSuccess)
                    {
                        if (!String.IsNullOrEmpty(sms.PARTNER_NAME) && !dict.ContainsKey(sms.PARTNER_NAME))
                        {
                            IList<SmsModel> listSmsTemp = new List<SmsModel>();
                            listSmsTemp = listSuccess.Where(list => list.PARTNER_NAME == sms.PARTNER_NAME).ToList();
                            dict.Add(sms.PARTNER_NAME, listSmsTemp);
                        }

                        this.SMS_COUNT++;
                    }

                    string message = String.Empty;
                    foreach (var partner in dict)
                    {
                        if (!chkFormatJson.Checked) message = JsonConvert.SerializeObject(partner.Value);
                        else message = JsonConvert.SerializeObject(partner.Value, Formatting.Indented);

                        this.rabbitHelper.PublishMessage(String.Format(AppConfig.PARTNER_QUEUE_TEMP, partner.Key.ToLower().Trim()), message);
                        SetTextMonitor(message, Color.Green);
                    }

                    lblCount.Text = this.SMS_COUNT.ToString();
                }
            }
            catch (Exception ex)
            {
                SetTextMonitor("PushSMSToQueue: " + ex.ToString(), Color.Red);
                logger.Error("PushSMSToQueue", ex);
            }
        }

        private delegate void SetTextCallback(string text, Color color);
        private void SetTextMonitor(string text, Color color)
        {
            if (!chkLogInfo.Checked && color.Equals(Color.Green)) return;
            if (!chkLogError.Checked && color.Equals(Color.Red)) return;

            if (InvokeRequired)
            {
                Invoke(new SetTextCallback(SetTextMonitor), text, color);
            }
            else
            {
                if (rtbLog.Lines.Length > Convert.ToInt32(txtLimitLog.Text))
                    rtbLog.Clear();

                rtbLog.SelectionStart = rtbLog.TextLength;
                rtbLog.SelectionLength = 0;
                rtbLog.SelectionColor = color;
                rtbLog.AppendText(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss fff") + ": " + text + Environment.NewLine);
                rtbLog.SelectionColor = rtbLog.ForeColor;
                rtbLog.ScrollToCaret();
            }
        }

        private void TxtLimitLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnViewLog_Click(object sender, EventArgs e)
        {
            Process.Start(String.Format("{0}Logs", System.AppDomain.CurrentDomain.BaseDirectory));
        }

        private void BtnCleanLog_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
            lblCount.Text = "0";
            this.SMS_COUNT = 0;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                base.OnFormClosing(e);
                if (e.CloseReason == CloseReason.WindowsShutDown) return;

                if (MessageBox.Show(this, "Close PushSMS and kill process ?", "Closing", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (this.oracleDependency != null && this.oracleDependency.IsEnabled)
                    {
                        this.oracleDependency.OnChange -= new OnChangeEventHandler(OracleListenerCallback);
                        this.oracleDependency?.RemoveRegistration(this.connection);
                        this.connection?.Close();
                        this.connection?.Dispose();
                    }

                    logger.Info("Stoped application !");
                    Process.GetCurrentProcess().Kill();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                logger.Error(AppConst.A("OnFormClosing", ex));
                Process.GetCurrentProcess().Kill();
            }
        }

        private void CbbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMode.SelectedIndex == 1)
            {
                lblInterval.Visible = true;
                cbbInterval.Visible = true;
            }
            else
            {
                lblInterval.Visible = false;
                cbbInterval.Visible = false;
            }
        }

        private void CbbInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CbbCountSMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CbbSmsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSmsType.SelectedIndex == 1)
            {
                cbbCountSMS.Text = AppConst.LIMIT_QC.ToString();
                this.Text = "Push SMS QC Conek - v1.0";
                tabPagePushSMS.Text = "Push SMS QC";
            }
            else
            {
                this.Text = "Push SMS CSKH Conek - v1.0";
                tabPagePushSMS.Text = "Push SMS CSKH";
                cbbCountSMS.Text = "100";
            }
        }
    }
}
