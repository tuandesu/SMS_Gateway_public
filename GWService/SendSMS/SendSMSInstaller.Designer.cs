﻿namespace SendSMS
{
    partial class SendSMSInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.svProcessSendSMS = new System.ServiceProcess.ServiceProcessInstaller();
            this.svInstallSendSMS = new System.ServiceProcess.ServiceInstaller();
            // 
            // svProcessSendSMS
            // 
            this.svProcessSendSMS.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.svProcessSendSMS.Password = null;
            this.svProcessSendSMS.Username = null;
            // 
            // svInstallSendSMS
            // 
            this.svInstallSendSMS.Description = "Send SMS";
            this.svInstallSendSMS.DisplayName = "Send_SMS";
            this.svInstallSendSMS.ServiceName = "SendSMS";
            // 
            // SendSMSInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.svProcessSendSMS,
            this.svInstallSendSMS});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller svProcessSendSMS;
        private System.ServiceProcess.ServiceInstaller svInstallSendSMS;
    }
}