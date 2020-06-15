﻿[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "VmgServiceSoap", Namespace = "http://tempuri.org/")]
public partial class VmgService : System.Web.Services.Protocols.SoapHttpClientProtocol
{
    private System.Threading.SendOrPostCallback AdsSendSmsOperationCompleted;

    private System.Threading.SendOrPostCallback BulkSendSmsOperationCompleted;

    /// <remarks/>
    public VmgService(string url = "http://brandsms.vn:8018/VMGAPI.asmx")
    {
        this.Url = url;
    }

    /// <remarks/>
    public event AdsSendSmsCompletedEventHandler AdsSendSmsCompleted;

    /// <remarks/>
    public event BulkSendSmsCompletedEventHandler BulkSendSmsCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AdsSendSms", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public ApiAdsReturn AdsSendSms(string[] msisdns, string alias, string message, string sendTime, string authenticateUser, string authenticatePass)
    {
        object[] results = this.Invoke("AdsSendSms", new object[] {
                    msisdns,
                    alias,
                    message,
                    sendTime,
                    authenticateUser,
                    authenticatePass});
        return ((ApiAdsReturn)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginAdsSendSms(string[] msisdns, string alias, string message, string sendTime, string authenticateUser, string authenticatePass, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("AdsSendSms", new object[] {
                    msisdns,
                    alias,
                    message,
                    sendTime,
                    authenticateUser,
                    authenticatePass}, callback, asyncState);
    }

    /// <remarks/>
    public ApiAdsReturn EndAdsSendSms(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((ApiAdsReturn)(results[0]));
    }

    /// <remarks/>
    public void AdsSendSmsAsync(string[] msisdns, string alias, string message, string sendTime, string authenticateUser, string authenticatePass)
    {
        this.AdsSendSmsAsync(msisdns, alias, message, sendTime, authenticateUser, authenticatePass, null);
    }

    /// <remarks/>
    public void AdsSendSmsAsync(string[] msisdns, string alias, string message, string sendTime, string authenticateUser, string authenticatePass, object userState)
    {
        if ((this.AdsSendSmsOperationCompleted == null))
        {
            this.AdsSendSmsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAdsSendSmsOperationCompleted);
        }
        this.InvokeAsync("AdsSendSms", new object[] {
                    msisdns,
                    alias,
                    message,
                    sendTime,
                    authenticateUser,
                    authenticatePass}, this.AdsSendSmsOperationCompleted, userState);
    }

    private void OnAdsSendSmsOperationCompleted(object arg)
    {
        if ((this.AdsSendSmsCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AdsSendSmsCompleted(this, new AdsSendSmsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BulkSendSms", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public ApiBulkReturn BulkSendSms(string msisdn, string alias, string message, string sendTime, string authenticateUser, string authenticatePass)
    {
        object[] results = this.Invoke("BulkSendSms", new object[] {
                    msisdn,
                    alias,
                    message,
                    sendTime,
                    authenticateUser,
                    authenticatePass});
        return ((ApiBulkReturn)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginBulkSendSms(string msisdn, string alias, string message, string sendTime, string authenticateUser, string authenticatePass, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("BulkSendSms", new object[] {
                    msisdn,
                    alias,
                    message,
                    sendTime,
                    authenticateUser,
                    authenticatePass}, callback, asyncState);
    }

    /// <remarks/>
    public ApiBulkReturn EndBulkSendSms(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((ApiBulkReturn)(results[0]));
    }

    /// <remarks/>
    public void BulkSendSmsAsync(string msisdn, string alias, string message, string sendTime, string authenticateUser, string authenticatePass)
    {
        this.BulkSendSmsAsync(msisdn, alias, message, sendTime, authenticateUser, authenticatePass, null);
    }

    /// <remarks/>
    public void BulkSendSmsAsync(string msisdn, string alias, string message, string sendTime, string authenticateUser, string authenticatePass, object userState)
    {
        if ((this.BulkSendSmsOperationCompleted == null))
        {
            this.BulkSendSmsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBulkSendSmsOperationCompleted);
        }
        this.InvokeAsync("BulkSendSms", new object[] {
                    msisdn,
                    alias,
                    message,
                    sendTime,
                    authenticateUser,
                    authenticatePass}, this.BulkSendSmsOperationCompleted, userState);
    }

    private void OnBulkSendSmsOperationCompleted(object arg)
    {
        if ((this.BulkSendSmsCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.BulkSendSmsCompleted(this, new BulkSendSmsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    public new void CancelAsync(object userState)
    {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
public partial class ApiAdsReturn
{

    private int error_codeField;

    private string error_detailField;

    private string prog_codeField;

    private APIAdsSendMT[] detailField;

    /// <remarks/>
    public int error_code
    {
        get
        {
            return this.error_codeField;
        }
        set
        {
            this.error_codeField = value;
        }
    }

    /// <remarks/>
    public string error_detail
    {
        get
        {
            return this.error_detailField;
        }
        set
        {
            this.error_detailField = value;
        }
    }

    /// <remarks/>
    public string prog_code
    {
        get
        {
            return this.prog_codeField;
        }
        set
        {
            this.prog_codeField = value;
        }
    }

    /// <remarks/>
    public APIAdsSendMT[] detail
    {
        get
        {
            return this.detailField;
        }
        set
        {
            this.detailField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
public partial class APIAdsSendMT
{

    private string telcoField;

    private int error_codeField;

    private string error_detailField;

    private string prog_codeField;

    private int total_subField;

    private int total_smsField;

    /// <remarks/>
    public string telco
    {
        get
        {
            return this.telcoField;
        }
        set
        {
            this.telcoField = value;
        }
    }

    /// <remarks/>
    public int error_code
    {
        get
        {
            return this.error_codeField;
        }
        set
        {
            this.error_codeField = value;
        }
    }

    /// <remarks/>
    public string error_detail
    {
        get
        {
            return this.error_detailField;
        }
        set
        {
            this.error_detailField = value;
        }
    }

    /// <remarks/>
    public string prog_code
    {
        get
        {
            return this.prog_codeField;
        }
        set
        {
            this.prog_codeField = value;
        }
    }

    /// <remarks/>
    public int total_sub
    {
        get
        {
            return this.total_subField;
        }
        set
        {
            this.total_subField = value;
        }
    }

    /// <remarks/>
    public int total_sms
    {
        get
        {
            return this.total_smsField;
        }
        set
        {
            this.total_smsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
public partial class ApiBulkReturn
{

    private int error_codeField;

    private string error_detailField;

    private long messageIdField;

    /// <remarks/>
    public int error_code
    {
        get
        {
            return this.error_codeField;
        }
        set
        {
            this.error_codeField = value;
        }
    }

    /// <remarks/>
    public string error_detail
    {
        get
        {
            return this.error_detailField;
        }
        set
        {
            this.error_detailField = value;
        }
    }

    /// <remarks/>
    public long messageId
    {
        get
        {
            return this.messageIdField;
        }
        set
        {
            this.messageIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void AdsSendSmsCompletedEventHandler(object sender, AdsSendSmsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AdsSendSmsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal AdsSendSmsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public ApiAdsReturn Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((ApiAdsReturn)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void BulkSendSmsCompletedEventHandler(object sender, BulkSendSmsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class BulkSendSmsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal BulkSendSmsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public ApiBulkReturn Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((ApiBulkReturn)(this.results[0]));
        }
    }
}
