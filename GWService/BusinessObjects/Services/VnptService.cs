﻿[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "VnptServiceBinding", Namespace = "http://sms.mc.vasc.com/")]
public partial class VnptService : System.Web.Services.Protocols.SoapHttpClientProtocol
{
    private System.Threading.SendOrPostCallback uploadSMSOperationCompleted;

    /// <remarks/>
    public VnptService(string url = "http://123.29.69.74:8889/WSSMSAdminBR/BrandNameWS")
    {
        this.Url = url;
    }

    /// <remarks/>
    public event uploadSMSCompletedEventHandler uploadSMSCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://sms.mc.vasc.com/", ResponseNamespace = "http://sms.mc.vasc.com/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int uploadSMS([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string username, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string serviceId, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string userId, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string contentType, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string serviceKind, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string infor)
    {
        object[] results = this.Invoke("uploadSMS", new object[] {
                    username,
                    password,
                    serviceId,
                    userId,
                    contentType,
                    serviceKind,
                    infor});
        return ((int)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginuploadSMS(string username, string password, string serviceId, string userId, string contentType, string serviceKind, string infor, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("uploadSMS", new object[] {
                    username,
                    password,
                    serviceId,
                    userId,
                    contentType,
                    serviceKind,
                    infor}, callback, asyncState);
    }

    /// <remarks/>
    public int EnduploadSMS(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks/>
    public void uploadSMSAsync(string username, string password, string serviceId, string userId, string contentType, string serviceKind, string infor)
    {
        this.uploadSMSAsync(username, password, serviceId, userId, contentType, serviceKind, infor, null);
    }

    /// <remarks/>
    public void uploadSMSAsync(string username, string password, string serviceId, string userId, string contentType, string serviceKind, string infor, object userState)
    {
        if ((this.uploadSMSOperationCompleted == null))
        {
            this.uploadSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnuploadSMSOperationCompleted);
        }
        this.InvokeAsync("uploadSMS", new object[] {
                    username,
                    password,
                    serviceId,
                    userId,
                    contentType,
                    serviceKind,
                    infor}, this.uploadSMSOperationCompleted, userState);
    }

    private void OnuploadSMSOperationCompleted(object arg)
    {
        if ((this.uploadSMSCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.uploadSMSCompleted(this, new uploadSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
public delegate void uploadSMSCompletedEventHandler(object sender, uploadSMSCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class uploadSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal uploadSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
