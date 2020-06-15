﻿using BusinessObjects.Models;
using BusinessObjects.Repositorys;
using BusinessObjects.Supports;
using log4net;
using Newtonsoft.Json;
using System;
using System.ServiceProcess;
using System.Threading;

namespace PullSMS_Success
{
    public partial class PullSMS_Success : ServiceBase
    {
        private readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private RabbitHelper rabbitHelper = new RabbitHelper();
        private CancellationTokenSource cancelToken;

        public PullSMS_Success()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                this.cancelToken = new CancellationTokenSource();

                this.rabbitHelper.Initialize();
                this.rabbitHelper.Worker = 1;
                this.rabbitHelper.ReceiveEvent += ReceivedHandlerCallback;
                this.rabbitHelper.ReceiveMessage(AppConfig.QUEUE_SUCCESS);
                logger.Info(AppConst.A("OnStart", "Started listener!"));
            }
            catch (Exception ex)
            {
                logger.Error("OnStart", ex);
            }
        }

        private async void ReceivedHandlerCallback(string message, int task)
        {
            try
            {
                logger.Info(AppConst.A("ReceivedHandlerCallback Deliver", task, message));

                if (!String.IsNullOrEmpty(message))
                {
                    SmsModel sms = JsonConvert.DeserializeObject<SmsModel>(message);
                    await (new SmsRepository()).UpdateSMSSuccessAsync(sms);
                }
            }
            catch (Exception ex)
            {
                logger.Error(AppConst.A("ReceivedHandlerCallback", ex));
            }
        }

        protected override void OnStop()
        {
            try
            {
                this.rabbitHelper.StopEventReceiveSMS();
                this.rabbitHelper.ReceiveEvent -= ReceivedHandlerCallback;

                if (this.cancelToken != null)
                    this.cancelToken.Cancel();
            }
            catch (Exception ex)
            {
                logger.Error("OnStop", ex);
            }

            logger.Info("Stoped application !");
        }
    }
}
