﻿[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "VhtServiceBinding", Namespace = "http://core.ws.brandname.tuankiet.com")]
public partial class VhtService : System.Web.Services.Protocols.SoapHttpClientProtocol
{
    private System.Threading.SendOrPostCallback sendSmsOperationCompleted;

    private System.Threading.SendOrPostCallback sendSmsToListPhoneOperationCompleted;

    private System.Threading.SendOrPostCallback getStatusPartnerOperationCompleted;

    private System.Threading.SendOrPostCallback sendUniOperationCompleted;

    private System.Threading.SendOrPostCallback getBrandNamesOperationCompleted;

    private System.Threading.SendOrPostCallback sendFlashOperationCompleted;

    private System.Threading.SendOrPostCallback getBalanceOperationCompleted;

    private System.Threading.SendOrPostCallback sendSmsWapOperationCompleted;

    private System.Threading.SendOrPostCallback createSenderOperationCompleted;

    private System.Threading.SendOrPostCallback sendSmsFlashOperationCompleted;

    private System.Threading.SendOrPostCallback sendOperationCompleted;

    private System.Threading.SendOrPostCallback sendSmsReportOperationCompleted;

    /// <remarks/>
    public VhtService(string url = "http://bc.vht.com.vn:8440/vht/services/sms.smsHttpSoap11Endpoint/")
    {
        this.Url = url;
    }

    /// <remarks/>
    public event sendSmsCompletedEventHandler sendSmsCompleted;

    /// <remarks/>
    public event sendSmsToListPhoneCompletedEventHandler sendSmsToListPhoneCompleted;

    /// <remarks/>
    public event getStatusPartnerCompletedEventHandler getStatusPartnerCompleted;

    /// <remarks/>
    public event sendUniCompletedEventHandler sendUniCompleted;

    /// <remarks/>
    public event getBrandNamesCompletedEventHandler getBrandNamesCompleted;

    /// <remarks/>
    public event sendFlashCompletedEventHandler sendFlashCompleted;

    /// <remarks/>
    public event getBalanceCompletedEventHandler getBalanceCompleted;

    /// <remarks/>
    public event sendSmsWapCompletedEventHandler sendSmsWapCompleted;

    /// <remarks/>
    public event createSenderCompletedEventHandler createSenderCompleted;

    /// <remarks/>
    public event sendSmsFlashCompletedEventHandler sendSmsFlashCompleted;

    /// <remarks/>
    public event sendCompletedEventHandler sendCompleted;

    /// <remarks/>
    public event sendSmsReportCompletedEventHandler sendSmsReportCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendSms", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void sendSms([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string phone, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string from, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sms, out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
    {
        object[] results = this.Invoke("sendSms", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms});
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendSms(string code, string account, string phone, string from, string sms, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("sendSms", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms}, callback, asyncState);
    }

    /// <remarks/>
    public void EndsendSms(System.IAsyncResult asyncResult, out int @return, out bool returnSpecified)
    {
        object[] results = this.EndInvoke(asyncResult);
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public void sendSmsAsync(string code, string account, string phone, string from, string sms)
    {
        this.sendSmsAsync(code, account, phone, from, sms, null);
    }

    /// <remarks/>
    public void sendSmsAsync(string code, string account, string phone, string from, string sms, object userState)
    {
        if ((this.sendSmsOperationCompleted == null))
        {
            this.sendSmsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendSmsOperationCompleted);
        }
        this.InvokeAsync("sendSms", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms}, this.sendSmsOperationCompleted, userState);
    }

    private void OnsendSmsOperationCompleted(object arg)
    {
        if ((this.sendSmsCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendSmsCompleted(this, new sendSmsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendSmsToListPhone", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void sendSmsToListPhone([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string phones, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sender, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sms, out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
    {
        object[] results = this.Invoke("sendSmsToListPhone", new object[] {
                    code,
                    account,
                    phones,
                    sender,
                    sms});
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendSmsToListPhone(string code, string account, string phones, string sender, string sms, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("sendSmsToListPhone", new object[] {
                    code,
                    account,
                    phones,
                    sender,
                    sms}, callback, asyncState);
    }

    /// <remarks/>
    public void EndsendSmsToListPhone(System.IAsyncResult asyncResult, out int @return, out bool returnSpecified)
    {
        object[] results = this.EndInvoke(asyncResult);
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public void sendSmsToListPhoneAsync(string code, string account, string phones, string sender, string sms)
    {
        this.sendSmsToListPhoneAsync(code, account, phones, sender, sms, null);
    }

    /// <remarks/>
    public void sendSmsToListPhoneAsync(string code, string account, string phones, string sender, string sms, object userState)
    {
        if ((this.sendSmsToListPhoneOperationCompleted == null))
        {
            this.sendSmsToListPhoneOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendSmsToListPhoneOperationCompleted);
        }
        this.InvokeAsync("sendSmsToListPhone", new object[] {
                    code,
                    account,
                    phones,
                    sender,
                    sms}, this.sendSmsToListPhoneOperationCompleted, userState);
    }

    private void OnsendSmsToListPhoneOperationCompleted(object arg)
    {
        if ((this.sendSmsToListPhoneCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendSmsToListPhoneCompleted(this, new sendSmsToListPhoneCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getStatusPartner", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable = true)]
    public string getStatusPartner([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string partnerId)
    {
        object[] results = this.Invoke("getStatusPartner", new object[] {
                    username,
                    code,
                    partnerId});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetStatusPartner(string username, string code, string partnerId, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getStatusPartner", new object[] {
                    username,
                    code,
                    partnerId}, callback, asyncState);
    }

    /// <remarks/>
    public string EndgetStatusPartner(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void getStatusPartnerAsync(string username, string code, string partnerId)
    {
        this.getStatusPartnerAsync(username, code, partnerId, null);
    }

    /// <remarks/>
    public void getStatusPartnerAsync(string username, string code, string partnerId, object userState)
    {
        if ((this.getStatusPartnerOperationCompleted == null))
        {
            this.getStatusPartnerOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetStatusPartnerOperationCompleted);
        }
        this.InvokeAsync("getStatusPartner", new object[] {
                    username,
                    code,
                    partnerId}, this.getStatusPartnerOperationCompleted, userState);
    }

    private void OngetStatusPartnerOperationCompleted(object arg)
    {
        if ((this.getStatusPartnerCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getStatusPartnerCompleted(this, new getStatusPartnerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendUni", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void sendUni([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string phone, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string from, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sms, out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
    {
        object[] results = this.Invoke("sendUni", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms});
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendUni(string code, string account, string phone, string from, string sms, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("sendUni", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms}, callback, asyncState);
    }

    /// <remarks/>
    public void EndsendUni(System.IAsyncResult asyncResult, out int @return, out bool returnSpecified)
    {
        object[] results = this.EndInvoke(asyncResult);
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public void sendUniAsync(string code, string account, string phone, string from, string sms)
    {
        this.sendUniAsync(code, account, phone, from, sms, null);
    }

    /// <remarks/>
    public void sendUniAsync(string code, string account, string phone, string from, string sms, object userState)
    {
        if ((this.sendUniOperationCompleted == null))
        {
            this.sendUniOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendUniOperationCompleted);
        }
        this.InvokeAsync("sendUni", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms}, this.sendUniOperationCompleted, userState);
    }

    private void OnsendUniOperationCompleted(object arg)
    {
        if ((this.sendUniCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendUniCompleted(this, new sendUniCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getBrandNames", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable = true)]
    public string getBrandNames([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code)
    {
        object[] results = this.Invoke("getBrandNames", new object[] {
                    account,
                    code});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetBrandNames(string account, string code, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getBrandNames", new object[] {
                    account,
                    code}, callback, asyncState);
    }

    /// <remarks/>
    public string EndgetBrandNames(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void getBrandNamesAsync(string account, string code)
    {
        this.getBrandNamesAsync(account, code, null);
    }

    /// <remarks/>
    public void getBrandNamesAsync(string account, string code, object userState)
    {
        if ((this.getBrandNamesOperationCompleted == null))
        {
            this.getBrandNamesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetBrandNamesOperationCompleted);
        }
        this.InvokeAsync("getBrandNames", new object[] {
                    account,
                    code}, this.getBrandNamesOperationCompleted, userState);
    }

    private void OngetBrandNamesOperationCompleted(object arg)
    {
        if ((this.getBrandNamesCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getBrandNamesCompleted(this, new getBrandNamesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendFlash", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void sendFlash([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string phone, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string from, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sms, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string ipAddress, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string deliveryTime, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sign, out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
    {
        object[] results = this.Invoke("sendFlash", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms,
                    ipAddress,
                    deliveryTime,
                    sign});
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendFlash(string code, string account, string phone, string from, string sms, string ipAddress, string deliveryTime, string sign, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("sendFlash", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms,
                    ipAddress,
                    deliveryTime,
                    sign}, callback, asyncState);
    }

    /// <remarks/>
    public void EndsendFlash(System.IAsyncResult asyncResult, out int @return, out bool returnSpecified)
    {
        object[] results = this.EndInvoke(asyncResult);
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public void sendFlashAsync(string code, string account, string phone, string from, string sms, string ipAddress, string deliveryTime, string sign)
    {
        this.sendFlashAsync(code, account, phone, from, sms, ipAddress, deliveryTime, sign, null);
    }

    /// <remarks/>
    public void sendFlashAsync(string code, string account, string phone, string from, string sms, string ipAddress, string deliveryTime, string sign, object userState)
    {
        if ((this.sendFlashOperationCompleted == null))
        {
            this.sendFlashOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendFlashOperationCompleted);
        }
        this.InvokeAsync("sendFlash", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms,
                    ipAddress,
                    deliveryTime,
                    sign}, this.sendFlashOperationCompleted, userState);
    }

    private void OnsendFlashOperationCompleted(object arg)
    {
        if ((this.sendFlashCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendFlashCompleted(this, new sendFlashCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getBalance", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void getBalance([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
    {
        object[] results = this.Invoke("getBalance", new object[] {
                    account,
                    code});
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetBalance(string account, string code, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getBalance", new object[] {
                    account,
                    code}, callback, asyncState);
    }

    /// <remarks/>
    public void EndgetBalance(System.IAsyncResult asyncResult, out int @return, out bool returnSpecified)
    {
        object[] results = this.EndInvoke(asyncResult);
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public void getBalanceAsync(string account, string code)
    {
        this.getBalanceAsync(account, code, null);
    }

    /// <remarks/>
    public void getBalanceAsync(string account, string code, object userState)
    {
        if ((this.getBalanceOperationCompleted == null))
        {
            this.getBalanceOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetBalanceOperationCompleted);
        }
        this.InvokeAsync("getBalance", new object[] {
                    account,
                    code}, this.getBalanceOperationCompleted, userState);
    }

    private void OngetBalanceOperationCompleted(object arg)
    {
        if ((this.getBalanceCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getBalanceCompleted(this, new getBalanceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendSmsWap", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void sendSmsWap([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string phone, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string from, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sms, out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
    {
        object[] results = this.Invoke("sendSmsWap", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms});
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendSmsWap(string code, string account, string phone, string from, string sms, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("sendSmsWap", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms}, callback, asyncState);
    }

    /// <remarks/>
    public void EndsendSmsWap(System.IAsyncResult asyncResult, out int @return, out bool returnSpecified)
    {
        object[] results = this.EndInvoke(asyncResult);
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public void sendSmsWapAsync(string code, string account, string phone, string from, string sms)
    {
        this.sendSmsWapAsync(code, account, phone, from, sms, null);
    }

    /// <remarks/>
    public void sendSmsWapAsync(string code, string account, string phone, string from, string sms, object userState)
    {
        if ((this.sendSmsWapOperationCompleted == null))
        {
            this.sendSmsWapOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendSmsWapOperationCompleted);
        }
        this.InvokeAsync("sendSmsWap", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms}, this.sendSmsWapOperationCompleted, userState);
    }

    private void OnsendSmsWapOperationCompleted(object arg)
    {
        if ((this.sendSmsWapCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendSmsWapCompleted(this, new sendSmsWapCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:createSender", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void createSender([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sender, out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
    {
        object[] results = this.Invoke("createSender", new object[] {
                    account,
                    code,
                    sender});
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public System.IAsyncResult BegincreateSender(string account, string code, string sender, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("createSender", new object[] {
                    account,
                    code,
                    sender}, callback, asyncState);
    }

    /// <remarks/>
    public void EndcreateSender(System.IAsyncResult asyncResult, out int @return, out bool returnSpecified)
    {
        object[] results = this.EndInvoke(asyncResult);
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public void createSenderAsync(string account, string code, string sender)
    {
        this.createSenderAsync(account, code, sender, null);
    }

    /// <remarks/>
    public void createSenderAsync(string account, string code, string sender, object userState)
    {
        if ((this.createSenderOperationCompleted == null))
        {
            this.createSenderOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateSenderOperationCompleted);
        }
        this.InvokeAsync("createSender", new object[] {
                    account,
                    code,
                    sender}, this.createSenderOperationCompleted, userState);
    }

    private void OncreateSenderOperationCompleted(object arg)
    {
        if ((this.createSenderCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.createSenderCompleted(this, new createSenderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendSmsFlash", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void sendSmsFlash([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string phone, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string from, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sms, out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
    {
        object[] results = this.Invoke("sendSmsFlash", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms});
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendSmsFlash(string code, string account, string phone, string from, string sms, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("sendSmsFlash", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms}, callback, asyncState);
    }

    /// <remarks/>
    public void EndsendSmsFlash(System.IAsyncResult asyncResult, out int @return, out bool returnSpecified)
    {
        object[] results = this.EndInvoke(asyncResult);
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public void sendSmsFlashAsync(string code, string account, string phone, string from, string sms)
    {
        this.sendSmsFlashAsync(code, account, phone, from, sms, null);
    }

    /// <remarks/>
    public void sendSmsFlashAsync(string code, string account, string phone, string from, string sms, object userState)
    {
        if ((this.sendSmsFlashOperationCompleted == null))
        {
            this.sendSmsFlashOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendSmsFlashOperationCompleted);
        }
        this.InvokeAsync("sendSmsFlash", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms}, this.sendSmsFlashOperationCompleted, userState);
    }

    private void OnsendSmsFlashOperationCompleted(object arg)
    {
        if ((this.sendSmsFlashCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendSmsFlashCompleted(this, new sendSmsFlashCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:send", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void send([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string phone, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string from, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sms, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string ipAddress, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string deliveryTime, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sign, out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
    {
        object[] results = this.Invoke("send", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms,
                    ipAddress,
                    deliveryTime,
                    sign});
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginsend(string code, string account, string phone, string from, string sms, string ipAddress, string deliveryTime, string sign, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("send", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms,
                    ipAddress,
                    deliveryTime,
                    sign}, callback, asyncState);
    }

    /// <remarks/>
    public void Endsend(System.IAsyncResult asyncResult, out int @return, out bool returnSpecified)
    {
        object[] results = this.EndInvoke(asyncResult);
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public void sendAsync(string code, string account, string phone, string from, string sms, string ipAddress, string deliveryTime, string sign)
    {
        this.sendAsync(code, account, phone, from, sms, ipAddress, deliveryTime, sign, null);
    }

    /// <remarks/>
    public void sendAsync(string code, string account, string phone, string from, string sms, string ipAddress, string deliveryTime, string sign, object userState)
    {
        if ((this.sendOperationCompleted == null))
        {
            this.sendOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendOperationCompleted);
        }
        this.InvokeAsync("send", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms,
                    ipAddress,
                    deliveryTime,
                    sign}, this.sendOperationCompleted, userState);
    }

    private void OnsendOperationCompleted(object arg)
    {
        if ((this.sendCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendCompleted(this, new sendCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendSmsReport", RequestNamespace = "http://core.ws.brandname.tuankiet.com", ResponseNamespace = "http://core.ws.brandname.tuankiet.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public void sendSmsReport([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string code, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string account, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string phone, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string from, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sms, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string partnerId, out int @return, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnSpecified)
    {
        object[] results = this.Invoke("sendSmsReport", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms,
                    partnerId});
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginsendSmsReport(string code, string account, string phone, string from, string sms, string partnerId, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("sendSmsReport", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms,
                    partnerId}, callback, asyncState);
    }

    /// <remarks/>
    public void EndsendSmsReport(System.IAsyncResult asyncResult, out int @return, out bool returnSpecified)
    {
        object[] results = this.EndInvoke(asyncResult);
        @return = ((int)(results[0]));
        returnSpecified = ((bool)(results[1]));
    }

    /// <remarks/>
    public void sendSmsReportAsync(string code, string account, string phone, string from, string sms, string partnerId)
    {
        this.sendSmsReportAsync(code, account, phone, from, sms, partnerId, null);
    }

    /// <remarks/>
    public void sendSmsReportAsync(string code, string account, string phone, string from, string sms, string partnerId, object userState)
    {
        if ((this.sendSmsReportOperationCompleted == null))
        {
            this.sendSmsReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendSmsReportOperationCompleted);
        }
        this.InvokeAsync("sendSmsReport", new object[] {
                    code,
                    account,
                    phone,
                    from,
                    sms,
                    partnerId}, this.sendSmsReportOperationCompleted, userState);
    }

    private void OnsendSmsReportOperationCompleted(object arg)
    {
        if ((this.sendSmsReportCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.sendSmsReportCompleted(this, new sendSmsReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
public delegate void sendSmsCompletedEventHandler(object sender, sendSmsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendSmsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendSmsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int @return
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }

    /// <remarks/>
    public bool returnSpecified
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[1]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void sendSmsToListPhoneCompletedEventHandler(object sender, sendSmsToListPhoneCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendSmsToListPhoneCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendSmsToListPhoneCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int @return
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }

    /// <remarks/>
    public bool returnSpecified
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[1]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void getStatusPartnerCompletedEventHandler(object sender, getStatusPartnerCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getStatusPartnerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getStatusPartnerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
public delegate void sendUniCompletedEventHandler(object sender, sendUniCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendUniCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendUniCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int @return
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }

    /// <remarks/>
    public bool returnSpecified
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[1]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void getBrandNamesCompletedEventHandler(object sender, getBrandNamesCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getBrandNamesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getBrandNamesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
public delegate void sendFlashCompletedEventHandler(object sender, sendFlashCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendFlashCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendFlashCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int @return
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }

    /// <remarks/>
    public bool returnSpecified
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[1]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void getBalanceCompletedEventHandler(object sender, getBalanceCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getBalanceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getBalanceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int @return
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }

    /// <remarks/>
    public bool returnSpecified
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[1]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void sendSmsWapCompletedEventHandler(object sender, sendSmsWapCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendSmsWapCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendSmsWapCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int @return
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }

    /// <remarks/>
    public bool returnSpecified
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[1]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void createSenderCompletedEventHandler(object sender, createSenderCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class createSenderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal createSenderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int @return
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }

    /// <remarks/>
    public bool returnSpecified
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[1]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void sendSmsFlashCompletedEventHandler(object sender, sendSmsFlashCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendSmsFlashCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendSmsFlashCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int @return
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }

    /// <remarks/>
    public bool returnSpecified
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[1]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void sendCompletedEventHandler(object sender, sendCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int @return
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }

    /// <remarks/>
    public bool returnSpecified
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[1]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void sendSmsReportCompletedEventHandler(object sender, sendSmsReportCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class sendSmsReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal sendSmsReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int @return
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }

    /// <remarks/>
    public bool returnSpecified
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((bool)(this.results[1]));
        }
    }
}
