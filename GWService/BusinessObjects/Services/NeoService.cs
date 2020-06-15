﻿[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "NeoServiceBinding", Namespace = "http://sms.neo")]
public partial class NeoService : System.Web.Services.Protocols.SoapHttpClientProtocol
{
    private System.Threading.SendOrPostCallback insertSMSOperationCompleted;

    private System.Threading.SendOrPostCallback sendFromServiceNumberOperationCompleted;

    private System.Threading.SendOrPostCallback sendMessageOperationCompleted;

    private System.Threading.SendOrPostCallback sendFromBrandnameOperationCompleted;

    private System.Threading.SendOrPostCallback useCardOperationCompleted;

    private System.Threading.SendOrPostCallback sendSMSOperationCompleted;

    /// <remarks/>
    public NeoService(string url = "http://g3g4.vn:8008/smsws/services/SendMT")
    {
        this.Url = url;
    }

    /// <remarks/>
    public event insertSMSCompletedEventHandler insertSMSCompleted;

    /// <remarks/>
    public event sendFromServiceNumberCompletedEventHandler sendFromServiceNumberCompleted;

    /// <remarks/>
    public event sendMessageCompletedEventHandler sendMessageCompleted;

    /// <remarks/>
    public event sendFromBrandnameCompletedEventHandler sendFromBrandnameCompleted;

    /// <remarks/>
    public event useCardCompletedEventHandler useCardCompleted;

    /// <remarks/>
    public event sendSMSCompletedEventHandler sendSMSCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:insertSMS", RequestNamespace = "http://sms.neo", ResponseNamespace = "http://sms.neo", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable = true)]
    public string insertSMS([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string receiver, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string content, int loaisp, [System.Xml.Serialization.XmlIgnoreAttribute()] bool loaispSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string brandname, int isUnicode, [System.Xml.Serialization.XmlIgnoreAttribute()] bool isUnicodeSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string target)
    {
        object[] results = this.Invoke("insertSMS", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    loaisp,
                    loaispSpecified,
                    brandname,
                    isUnicode,
                    isUnicodeSpecified,
                    target});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegininsertSMS(string username, string password, string receiver, string content, int loaisp, bool loaispSpecified, string brandname, int isUnicode, bool isUnicodeSpecified, string target, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("insertSMS", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    loaisp,
                    loaispSpecified,
                    brandname,
                    isUnicode,
                    isUnicodeSpecified,
                    target}, callback, asyncState);
    }

    /// <remarks/>
    public string EndinsertSMS(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void insertSMSAsync(string username, string password, string receiver, string content, int loaisp, bool loaispSpecified, string brandname, int isUnicode, bool isUnicodeSpecified, string target)
    {
        this.insertSMSAsync(username, password, receiver, content, loaisp, loaispSpecified, brandname, isUnicode, isUnicodeSpecified, target, null);
    }

    /// <remarks/>
    public void insertSMSAsync(string username, string password, string receiver, string content, int loaisp, bool loaispSpecified, string brandname, int isUnicode, bool isUnicodeSpecified, string target, object userState)
    {
        if ((this.insertSMSOperationCompleted == null))
        {
            this.insertSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OninsertSMSOperationCompleted);
        }
        this.InvokeAsync("insertSMS", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    loaisp,
                    loaispSpecified,
                    brandname,
                    isUnicode,
                    isUnicodeSpecified,
                    target}, this.insertSMSOperationCompleted, userState);
    }

    private void OninsertSMSOperationCompleted(object arg)
    {
        if ((this.insertSMSCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.insertSMSCompleted(this, new insertSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendFromServiceNumber", RequestNamespace = "http://sms.neo", ResponseNamespace = "http://sms.neo", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable = true)]
    public string sendFromServiceNumber([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string receiver, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string content, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string target)
    {
        object[] results = this.Invoke("sendFromServiceNumber", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    target});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendFromServiceNumber(string username, string password, string receiver, string content, string target, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("sendFromServiceNumber", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    target}, callback, asyncState);
    }

    /// <remarks/>
    public string EndsendFromServiceNumber(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void sendFromServiceNumberAsync(string username, string password, string receiver, string content, string target)
    {
        this.sendFromServiceNumberAsync(username, password, receiver, content, target, null);
    }

    /// <remarks/>
    public void sendFromServiceNumberAsync(string username, string password, string receiver, string content, string target, object userState)
    {
        if ((this.sendFromServiceNumberOperationCompleted == null))
        {
            this.sendFromServiceNumberOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendFromServiceNumberOperationCompleted);
        }
        this.InvokeAsync("sendFromServiceNumber", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    target}, this.sendFromServiceNumberOperationCompleted, userState);
    }

    private void OnsendFromServiceNumberOperationCompleted(object arg)
    {
        if ((this.sendFromServiceNumberCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendFromServiceNumberCompleted(this, new sendFromServiceNumberCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendMessage", RequestNamespace = "http://sms.neo", ResponseNamespace = "http://sms.neo", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable = true)]
    public string sendMessage([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string receiver, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string content, int repeat, [System.Xml.Serialization.XmlIgnoreAttribute()] bool repeatSpecified, int repeatType, [System.Xml.Serialization.XmlIgnoreAttribute()] bool repeatTypeSpecified, int loaisp, [System.Xml.Serialization.XmlIgnoreAttribute()] bool loaispSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string brandname, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string timestart, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string timeend, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string timesend, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string target)
    {
        object[] results = this.Invoke("sendMessage", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    repeat,
                    repeatSpecified,
                    repeatType,
                    repeatTypeSpecified,
                    loaisp,
                    loaispSpecified,
                    brandname,
                    timestart,
                    timeend,
                    timesend,
                    target});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendMessage(
                string username,
                string password,
                string receiver,
                string content,
                int repeat,
                bool repeatSpecified,
                int repeatType,
                bool repeatTypeSpecified,
                int loaisp,
                bool loaispSpecified,
                string brandname,
                string timestart,
                string timeend,
                string timesend,
                string target,
                System.AsyncCallback callback,
                object asyncState)
    {
        return this.BeginInvoke("sendMessage", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    repeat,
                    repeatSpecified,
                    repeatType,
                    repeatTypeSpecified,
                    loaisp,
                    loaispSpecified,
                    brandname,
                    timestart,
                    timeend,
                    timesend,
                    target}, callback, asyncState);
    }

    /// <remarks/>
    public string EndsendMessage(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void sendMessageAsync(string username, string password, string receiver, string content, int repeat, bool repeatSpecified, int repeatType, bool repeatTypeSpecified, int loaisp, bool loaispSpecified, string brandname, string timestart, string timeend, string timesend, string target)
    {
        this.sendMessageAsync(username, password, receiver, content, repeat, repeatSpecified, repeatType, repeatTypeSpecified, loaisp, loaispSpecified, brandname, timestart, timeend, timesend, target, null);
    }

    /// <remarks/>
    public void sendMessageAsync(
                string username,
                string password,
                string receiver,
                string content,
                int repeat,
                bool repeatSpecified,
                int repeatType,
                bool repeatTypeSpecified,
                int loaisp,
                bool loaispSpecified,
                string brandname,
                string timestart,
                string timeend,
                string timesend,
                string target,
                object userState)
    {
        if ((this.sendMessageOperationCompleted == null))
        {
            this.sendMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendMessageOperationCompleted);
        }
        this.InvokeAsync("sendMessage", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    repeat,
                    repeatSpecified,
                    repeatType,
                    repeatTypeSpecified,
                    loaisp,
                    loaispSpecified,
                    brandname,
                    timestart,
                    timeend,
                    timesend,
                    target}, this.sendMessageOperationCompleted, userState);
    }

    private void OnsendMessageOperationCompleted(object arg)
    {
        if ((this.sendMessageCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendMessageCompleted(this, new sendMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendFromBrandname", RequestNamespace = "http://sms.neo", ResponseNamespace = "http://sms.neo", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable = true)]
    public string sendFromBrandname([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string receiver, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string brandname, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string content, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string target)
    {
        object[] results = this.Invoke("sendFromBrandname", new object[] {
                    username,
                    password,
                    receiver,
                    brandname,
                    content,
                    target});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendFromBrandname(string username, string password, string receiver, string brandname, string content, string target, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("sendFromBrandname", new object[] {
                    username,
                    password,
                    receiver,
                    brandname,
                    content,
                    target}, callback, asyncState);
    }

    /// <remarks/>
    public string EndsendFromBrandname(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void sendFromBrandnameAsync(string username, string password, string receiver, string brandname, string content, string target)
    {
        this.sendFromBrandnameAsync(username, password, receiver, brandname, content, target, null);
    }

    /// <remarks/>
    public void sendFromBrandnameAsync(string username, string password, string receiver, string brandname, string content, string target, object userState)
    {
        if ((this.sendFromBrandnameOperationCompleted == null))
        {
            this.sendFromBrandnameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendFromBrandnameOperationCompleted);
        }
        this.InvokeAsync("sendFromBrandname", new object[] {
                    username,
                    password,
                    receiver,
                    brandname,
                    content,
                    target}, this.sendFromBrandnameOperationCompleted, userState);
    }

    private void OnsendFromBrandnameOperationCompleted(object arg)
    {
        if ((this.sendFromBrandnameCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendFromBrandnameCompleted(this, new sendFromBrandnameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:useCard", RequestNamespace = "http://sms.neo", ResponseNamespace = "http://sms.neo", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable = true)]
    public string useCard([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string issure, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string cardCode, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string cardSerial)
    {
        object[] results = this.Invoke("useCard", new object[] {
                    username,
                    password,
                    issure,
                    cardCode,
                    cardSerial});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginuseCard(string username, string password, string issure, string cardCode, string cardSerial, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("useCard", new object[] {
                    username,
                    password,
                    issure,
                    cardCode,
                    cardSerial}, callback, asyncState);
    }

    /// <remarks/>
    public string EnduseCard(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void useCardAsync(string username, string password, string issure, string cardCode, string cardSerial)
    {
        this.useCardAsync(username, password, issure, cardCode, cardSerial, null);
    }

    /// <remarks/>
    public void useCardAsync(string username, string password, string issure, string cardCode, string cardSerial, object userState)
    {
        if ((this.useCardOperationCompleted == null))
        {
            this.useCardOperationCompleted = new System.Threading.SendOrPostCallback(this.OnuseCardOperationCompleted);
        }
        this.InvokeAsync("useCard", new object[] {
                    username,
                    password,
                    issure,
                    cardCode,
                    cardSerial}, this.useCardOperationCompleted, userState);
    }

    private void OnuseCardOperationCompleted(object arg)
    {
        if ((this.useCardCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.useCardCompleted(this, new useCardCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendSMS", RequestNamespace = "http://sms.neo", ResponseNamespace = "http://sms.neo", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable = true)]
    public string sendSMS([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string receiver, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string content, int loaisp, [System.Xml.Serialization.XmlIgnoreAttribute()] bool loaispSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string brandname, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string target)
    {
        object[] results = this.Invoke("sendSMS", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    loaisp,
                    loaispSpecified,
                    brandname,
                    target});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendSMS(string username, string password, string receiver, string content, int loaisp, bool loaispSpecified, string brandname, string target, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("sendSMS", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    loaisp,
                    loaispSpecified,
                    brandname,
                    target}, callback, asyncState);
    }

    /// <remarks/>
    public string EndsendSMS(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void sendSMSAsync(string username, string password, string receiver, string content, int loaisp, bool loaispSpecified, string brandname, string target)
    {
        this.sendSMSAsync(username, password, receiver, content, loaisp, loaispSpecified, brandname, target, null);
    }

    /// <remarks/>
    public void sendSMSAsync(string username, string password, string receiver, string content, int loaisp, bool loaispSpecified, string brandname, string target, object userState)
    {
        if ((this.sendSMSOperationCompleted == null))
        {
            this.sendSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendSMSOperationCompleted);
        }
        this.InvokeAsync("sendSMS", new object[] {
                    username,
                    password,
                    receiver,
                    content,
                    loaisp,
                    loaispSpecified,
                    brandname,
                    target}, this.sendSMSOperationCompleted, userState);
    }

    private void OnsendSMSOperationCompleted(object arg)
    {
        if ((this.sendSMSCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendSMSCompleted(this, new sendSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
public delegate void insertSMSCompletedEventHandler(object sender, insertSMSCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class insertSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal insertSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void sendFromServiceNumberCompletedEventHandler(object sender, sendFromServiceNumberCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendFromServiceNumberCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendFromServiceNumberCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void sendMessageCompletedEventHandler(object sender, sendMessageCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void sendFromBrandnameCompletedEventHandler(object sender, sendFromBrandnameCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendFromBrandnameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendFromBrandnameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void useCardCompletedEventHandler(object sender, useCardCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class useCardCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal useCardCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void sendSMSCompletedEventHandler(object sender, sendSMSCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}
