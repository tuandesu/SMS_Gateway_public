﻿[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "IncomServiceSoap", Namespace = "http://203.162.168.170/SendMTAuth/")]
public partial class IncomService : System.Web.Services.Protocols.SoapHttpClientProtocol
{
    private System.Threading.SendOrPostCallback SendSMSOperationCompleted;

    private System.Threading.SendOrPostCallback SendSMSAdvertOperationCompleted;

    /// <remarks/>
    public IncomService(string url = "http://210.211.101.107/SendMTAuth/SendMT2.asmx")
    {
        this.Url = url;
    }

    /// <remarks/>
    public event SendSMSCompletedEventHandler SendSMSCompleted;

    /// <remarks/>
    public event SendSMSAdvertCompletedEventHandler SendSMSAdvertCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://203.162.168.170/SendMTAuth/SendSMS", RequestNamespace = "http://203.162.168.170/SendMTAuth/", ResponseNamespace = "http://203.162.168.170/SendMTAuth/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int SendSMS(string account_name, string account_password, string User_ID, string Content, string Service_ID, string Command_Code, string Request_ID, string Message_Type, string Total_Message, string Message_Index, string IsMore, string Content_Type)
    {
        object[] results = this.Invoke("SendSMS", new object[] {
                    account_name,
                    account_password,
                    User_ID,
                    Content,
                    Service_ID,
                    Command_Code,
                    Request_ID,
                    Message_Type,
                    Total_Message,
                    Message_Index,
                    IsMore,
                    Content_Type});
        return ((int)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginSendSMS(string account_name, string account_password, string User_ID, string Content, string Service_ID, string Command_Code, string Request_ID, string Message_Type, string Total_Message, string Message_Index, string IsMore, string Content_Type, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("SendSMS", new object[] {
                    account_name,
                    account_password,
                    User_ID,
                    Content,
                    Service_ID,
                    Command_Code,
                    Request_ID,
                    Message_Type,
                    Total_Message,
                    Message_Index,
                    IsMore,
                    Content_Type}, callback, asyncState);
    }

    /// <remarks/>
    public int EndSendSMS(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks/>
    public void SendSMSAsync(string account_name, string account_password, string User_ID, string Content, string Service_ID, string Command_Code, string Request_ID, string Message_Type, string Total_Message, string Message_Index, string IsMore, string Content_Type)
    {
        this.SendSMSAsync(account_name, account_password, User_ID, Content, Service_ID, Command_Code, Request_ID, Message_Type, Total_Message, Message_Index, IsMore, Content_Type, null);
    }

    /// <remarks/>
    public void SendSMSAsync(string account_name, string account_password, string User_ID, string Content, string Service_ID, string Command_Code, string Request_ID, string Message_Type, string Total_Message, string Message_Index, string IsMore, string Content_Type, object userState)
    {
        if ((this.SendSMSOperationCompleted == null))
        {
            this.SendSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSMSOperationCompleted);
        }
        this.InvokeAsync("SendSMS", new object[] {
                    account_name,
                    account_password,
                    User_ID,
                    Content,
                    Service_ID,
                    Command_Code,
                    Request_ID,
                    Message_Type,
                    Total_Message,
                    Message_Index,
                    IsMore,
                    Content_Type}, this.SendSMSOperationCompleted, userState);
    }

    private void OnSendSMSOperationCompleted(object arg)
    {
        if ((this.SendSMSCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SendSMSCompleted(this, new SendSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://203.162.168.170/SendMTAuth/SendSMSAdvert", RequestNamespace = "http://203.162.168.170/SendMTAuth/", ResponseNamespace = "http://203.162.168.170/SendMTAuth/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int SendSMSAdvert(string account_name, string account_password, string Phonenumber, string Message, string SendFrom, string CommandCode, string RequestID)
    {
        object[] results = this.Invoke("SendSMSAdvert", new object[] {
                    account_name,
                    account_password,
                    Phonenumber,
                    Message,
                    SendFrom,
                    CommandCode,
                    RequestID});
        return ((int)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginSendSMSAdvert(string account_name, string account_password, string Phonenumber, string Message, string SendFrom, string CommandCode, string RequestID, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("SendSMSAdvert", new object[] {
                    account_name,
                    account_password,
                    Phonenumber,
                    Message,
                    SendFrom,
                    CommandCode,
                    RequestID}, callback, asyncState);
    }

    /// <remarks/>
    public int EndSendSMSAdvert(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks/>
    public void SendSMSAdvertAsync(string account_name, string account_password, string Phonenumber, string Message, string SendFrom, string CommandCode, string RequestID)
    {
        this.SendSMSAdvertAsync(account_name, account_password, Phonenumber, Message, SendFrom, CommandCode, RequestID, null);
    }

    /// <remarks/>
    public void SendSMSAdvertAsync(string account_name, string account_password, string Phonenumber, string Message, string SendFrom, string CommandCode, string RequestID, object userState)
    {
        if ((this.SendSMSAdvertOperationCompleted == null))
        {
            this.SendSMSAdvertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSMSAdvertOperationCompleted);
        }
        this.InvokeAsync("SendSMSAdvert", new object[] {
                    account_name,
                    account_password,
                    Phonenumber,
                    Message,
                    SendFrom,
                    CommandCode,
                    RequestID}, this.SendSMSAdvertOperationCompleted, userState);
    }

    private void OnSendSMSAdvertOperationCompleted(object arg)
    {
        if ((this.SendSMSAdvertCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SendSMSAdvertCompleted(this, new SendSMSAdvertCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
public delegate void SendSMSCompletedEventHandler(object sender, SendSMSCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SendSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    private object[] results;

    internal SendSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void SendSMSAdvertCompletedEventHandler(object sender, SendSMSAdvertCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SendSMSAdvertCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    private object[] results;

    internal SendSMSAdvertCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }
}
