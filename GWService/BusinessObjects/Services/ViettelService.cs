﻿[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "CcApiPortBinding", Namespace = "http://impl.bulkSms.ws/")]
public partial class ViettelService : System.Web.Services.Protocols.SoapHttpClientProtocol
{

    private System.Threading.SendOrPostCallback wsGetCpCodeOperationCompleted;

    private System.Threading.SendOrPostCallback getFailSubOperationCompleted;

    private System.Threading.SendOrPostCallback wsCpBatchMtOperationCompleted;

    private System.Threading.SendOrPostCallback wsEcomCpMtOperationCompleted;

    private System.Threading.SendOrPostCallback wsCpMtRegDlrOperationCompleted;

    private System.Threading.SendOrPostCallback getDlrStatusOperationCompleted;

    private System.Threading.SendOrPostCallback wsCpMtOperationCompleted;

    private System.Threading.SendOrPostCallback wsReportHourOperationCompleted;

    private System.Threading.SendOrPostCallback wsReportDailyOperationCompleted;

    private System.Threading.SendOrPostCallback wsReportMonthOperationCompleted;

    private System.Threading.SendOrPostCallback wsCpMt2OperationCompleted;

    private System.Threading.SendOrPostCallback wsCpMt4OperationCompleted;

    private System.Threading.SendOrPostCallback checkBalanceOperationCompleted;

    private System.Threading.SendOrPostCallback getIpOperationCompleted;

    /// <remarks/>
    public ViettelService(string url = "http://ams.tinnhanthuonghieu.vn:8009/bulkapi")
    {
        this.Url = url;
    }

    /// <remarks/>
    public event wsGetCpCodeCompletedEventHandler wsGetCpCodeCompleted;

    /// <remarks/>
    public event getFailSubCompletedEventHandler getFailSubCompleted;

    /// <remarks/>
    public event wsCpBatchMtCompletedEventHandler wsCpBatchMtCompleted;

    /// <remarks/>
    public event wsEcomCpMtCompletedEventHandler wsEcomCpMtCompleted;

    /// <remarks/>
    public event wsCpMtRegDlrCompletedEventHandler wsCpMtRegDlrCompleted;

    /// <remarks/>
    public event getDlrStatusCompletedEventHandler getDlrStatusCompleted;

    /// <remarks/>
    public event wsCpMtCompletedEventHandler wsCpMtCompleted;

    /// <remarks/>
    public event wsReportHourCompletedEventHandler wsReportHourCompleted;

    /// <remarks/>
    public event wsReportDailyCompletedEventHandler wsReportDailyCompleted;

    /// <remarks/>
    public event wsReportMonthCompletedEventHandler wsReportMonthCompleted;

    /// <remarks/>
    public event wsCpMt2CompletedEventHandler wsCpMt2Completed;

    /// <remarks/>
    public event wsCpMt4CompletedEventHandler wsCpMt4Completed;

    /// <remarks/>
    public event checkBalanceCompletedEventHandler checkBalanceCompleted;

    /// <remarks/>
    public event getIpCompletedEventHandler getIpCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public resultCp wsGetCpCode([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string TaxCode)
    {
        object[] results = this.Invoke("wsGetCpCode", new object[] {
                    User,
                    Password,
                    CPCode,
                    TaxCode});
        return ((resultCp)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginwsGetCpCode(string User, string Password, string CPCode, string TaxCode, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("wsGetCpCode", new object[] {
                    User,
                    Password,
                    CPCode,
                    TaxCode}, callback, asyncState);
    }

    /// <remarks/>
    public resultCp EndwsGetCpCode(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((resultCp)(results[0]));
    }

    /// <remarks/>
    public void wsGetCpCodeAsync(string User, string Password, string CPCode, string TaxCode)
    {
        this.wsGetCpCodeAsync(User, Password, CPCode, TaxCode, null);
    }

    /// <remarks/>
    public void wsGetCpCodeAsync(string User, string Password, string CPCode, string TaxCode, object userState)
    {
        if ((this.wsGetCpCodeOperationCompleted == null))
        {
            this.wsGetCpCodeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsGetCpCodeOperationCompleted);
        }
        this.InvokeAsync("wsGetCpCode", new object[] {
                    User,
                    Password,
                    CPCode,
                    TaxCode}, this.wsGetCpCodeOperationCompleted, userState);
    }

    private void OnwsGetCpCodeOperationCompleted(object arg)
    {
        if ((this.wsGetCpCodeCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.wsGetCpCodeCompleted(this, new wsGetCpCodeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public failSubReponse getFailSub([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string username, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string cpCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string alias, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string date, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string pageNumber, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string pageSize)
    {
        object[] results = this.Invoke("getFailSub", new object[] {
                    username,
                    password,
                    cpCode,
                    alias,
                    date,
                    pageNumber,
                    pageSize});
        return ((failSubReponse)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetFailSub(string username, string password, string cpCode, string alias, string date, string pageNumber, string pageSize, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getFailSub", new object[] {
                    username,
                    password,
                    cpCode,
                    alias,
                    date,
                    pageNumber,
                    pageSize}, callback, asyncState);
    }

    /// <remarks/>
    public failSubReponse EndgetFailSub(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((failSubReponse)(results[0]));
    }

    /// <remarks/>
    public void getFailSubAsync(string username, string password, string cpCode, string alias, string date, string pageNumber, string pageSize)
    {
        this.getFailSubAsync(username, password, cpCode, alias, date, pageNumber, pageSize, null);
    }

    /// <remarks/>
    public void getFailSubAsync(string username, string password, string cpCode, string alias, string date, string pageNumber, string pageSize, object userState)
    {
        if ((this.getFailSubOperationCompleted == null))
        {
            this.getFailSubOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetFailSubOperationCompleted);
        }
        this.InvokeAsync("getFailSub", new object[] {
                    username,
                    password,
                    cpCode,
                    alias,
                    date,
                    pageNumber,
                    pageSize}, this.getFailSubOperationCompleted, userState);
    }

    private void OngetFailSubOperationCompleted(object arg)
    {
        if ((this.getFailSubCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getFailSubCompleted(this, new getFailSubCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public createMtResult wsCpBatchMt([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CommandCode, [System.Xml.Serialization.XmlElementAttribute("requestMt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] requestMt[] requestMt)
    {
        object[] results = this.Invoke("wsCpBatchMt", new object[] {
                    User,
                    Password,
                    CPCode,
                    CommandCode,
                    requestMt});
        return ((createMtResult)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginwsCpBatchMt(string User, string Password, string CPCode, string CommandCode, requestMt[] requestMt, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("wsCpBatchMt", new object[] {
                    User,
                    Password,
                    CPCode,
                    CommandCode,
                    requestMt}, callback, asyncState);
    }

    /// <remarks/>
    public createMtResult EndwsCpBatchMt(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((createMtResult)(results[0]));
    }

    /// <remarks/>
    public void wsCpBatchMtAsync(string User, string Password, string CPCode, string CommandCode, requestMt[] requestMt)
    {
        this.wsCpBatchMtAsync(User, Password, CPCode, CommandCode, requestMt, null);
    }

    /// <remarks/>
    public void wsCpBatchMtAsync(string User, string Password, string CPCode, string CommandCode, requestMt[] requestMt, object userState)
    {
        if ((this.wsCpBatchMtOperationCompleted == null))
        {
            this.wsCpBatchMtOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsCpBatchMtOperationCompleted);
        }
        this.InvokeAsync("wsCpBatchMt", new object[] {
                    User,
                    Password,
                    CPCode,
                    CommandCode,
                    requestMt}, this.wsCpBatchMtOperationCompleted, userState);
    }

    private void OnwsCpBatchMtOperationCompleted(object arg)
    {
        if ((this.wsCpBatchMtCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.wsCpBatchMtCompleted(this, new wsCpBatchMtCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public result wsEcomCpMt([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string RequestID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string UserID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ReceiverID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ServiceID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CommandCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Content, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ContentType, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string SaleOrderId, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string PackageId, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string OrderNum)
    {
        object[] results = this.Invoke("wsEcomCpMt", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType,
                    SaleOrderId,
                    PackageId,
                    OrderNum});
        return ((result)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginwsEcomCpMt(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType, string SaleOrderId, string PackageId, string OrderNum, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("wsEcomCpMt", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType,
                    SaleOrderId,
                    PackageId,
                    OrderNum}, callback, asyncState);
    }

    /// <remarks/>
    public result EndwsEcomCpMt(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((result)(results[0]));
    }

    /// <remarks/>
    public void wsEcomCpMtAsync(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType, string SaleOrderId, string PackageId, string OrderNum)
    {
        this.wsEcomCpMtAsync(User, Password, CPCode, RequestID, UserID, ReceiverID, ServiceID, CommandCode, Content, ContentType, SaleOrderId, PackageId, OrderNum, null);
    }

    /// <remarks/>
    public void wsEcomCpMtAsync(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType, string SaleOrderId, string PackageId, string OrderNum, object userState)
    {
        if ((this.wsEcomCpMtOperationCompleted == null))
        {
            this.wsEcomCpMtOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsEcomCpMtOperationCompleted);
        }
        this.InvokeAsync("wsEcomCpMt", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType,
                    SaleOrderId,
                    PackageId,
                    OrderNum}, this.wsEcomCpMtOperationCompleted, userState);
    }

    private void OnwsEcomCpMtOperationCompleted(object arg)
    {
        if ((this.wsEcomCpMtCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.wsEcomCpMtCompleted(this, new wsEcomCpMtCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public result wsCpMtRegDlr([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string RequestID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string UserID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ReceiverID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ServiceID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CommandCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Content, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ContentType)
    {
        object[] results = this.Invoke("wsCpMtRegDlr", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType});
        return ((result)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginwsCpMtRegDlr(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("wsCpMtRegDlr", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType}, callback, asyncState);
    }

    /// <remarks/>
    public result EndwsCpMtRegDlr(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((result)(results[0]));
    }

    /// <remarks/>
    public void wsCpMtRegDlrAsync(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType)
    {
        this.wsCpMtRegDlrAsync(User, Password, CPCode, RequestID, UserID, ReceiverID, ServiceID, CommandCode, Content, ContentType, null);
    }

    /// <remarks/>
    public void wsCpMtRegDlrAsync(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType, object userState)
    {
        if ((this.wsCpMtRegDlrOperationCompleted == null))
        {
            this.wsCpMtRegDlrOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsCpMtRegDlrOperationCompleted);
        }
        this.InvokeAsync("wsCpMtRegDlr", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType}, this.wsCpMtRegDlrOperationCompleted, userState);
    }

    private void OnwsCpMtRegDlrOperationCompleted(object arg)
    {
        if ((this.wsCpMtRegDlrCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.wsCpMtRegDlrCompleted(this, new wsCpMtRegDlrCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public resultDlr getDlrStatus([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string MessageIds)
    {
        object[] results = this.Invoke("getDlrStatus", new object[] {
                    User,
                    Password,
                    CPCode,
                    MessageIds});
        return ((resultDlr)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetDlrStatus(string User, string Password, string CPCode, string MessageIds, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getDlrStatus", new object[] {
                    User,
                    Password,
                    CPCode,
                    MessageIds}, callback, asyncState);
    }

    /// <remarks/>
    public resultDlr EndgetDlrStatus(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((resultDlr)(results[0]));
    }

    /// <remarks/>
    public void getDlrStatusAsync(string User, string Password, string CPCode, string MessageIds)
    {
        this.getDlrStatusAsync(User, Password, CPCode, MessageIds, null);
    }

    /// <remarks/>
    public void getDlrStatusAsync(string User, string Password, string CPCode, string MessageIds, object userState)
    {
        if ((this.getDlrStatusOperationCompleted == null))
        {
            this.getDlrStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDlrStatusOperationCompleted);
        }
        this.InvokeAsync("getDlrStatus", new object[] {
                    User,
                    Password,
                    CPCode,
                    MessageIds}, this.getDlrStatusOperationCompleted, userState);
    }

    private void OngetDlrStatusOperationCompleted(object arg)
    {
        if ((this.getDlrStatusCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getDlrStatusCompleted(this, new getDlrStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public result wsCpMt([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string RequestID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string UserID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ReceiverID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ServiceID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CommandCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Content, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ContentType)
    {
        object[] results = this.Invoke("wsCpMt", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType});
        return ((result)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginwsCpMt(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("wsCpMt", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType}, callback, asyncState);
    }

    /// <remarks/>
    public result EndwsCpMt(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((result)(results[0]));
    }

    /// <remarks/>
    public void wsCpMtAsync(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType)
    {
        this.wsCpMtAsync(User, Password, CPCode, RequestID, UserID, ReceiverID, ServiceID, CommandCode, Content, ContentType, null);
    }

    /// <remarks/>
    public void wsCpMtAsync(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType, object userState)
    {
        if ((this.wsCpMtOperationCompleted == null))
        {
            this.wsCpMtOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsCpMtOperationCompleted);
        }
        this.InvokeAsync("wsCpMt", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType}, this.wsCpMtOperationCompleted, userState);
    }

    private void OnwsCpMtOperationCompleted(object arg)
    {
        if ((this.wsCpMtCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.wsCpMtCompleted(this, new wsCpMtCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public reportHourBO[] wsReportHour([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string timeReport)
    {
        object[] results = this.Invoke("wsReportHour", new object[] {
                    User,
                    Password,
                    CPCode,
                    timeReport});
        return ((reportHourBO[])(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginwsReportHour(string User, string Password, string CPCode, string timeReport, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("wsReportHour", new object[] {
                    User,
                    Password,
                    CPCode,
                    timeReport}, callback, asyncState);
    }

    /// <remarks/>
    public reportHourBO[] EndwsReportHour(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((reportHourBO[])(results[0]));
    }

    /// <remarks/>
    public void wsReportHourAsync(string User, string Password, string CPCode, string timeReport)
    {
        this.wsReportHourAsync(User, Password, CPCode, timeReport, null);
    }

    /// <remarks/>
    public void wsReportHourAsync(string User, string Password, string CPCode, string timeReport, object userState)
    {
        if ((this.wsReportHourOperationCompleted == null))
        {
            this.wsReportHourOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsReportHourOperationCompleted);
        }
        this.InvokeAsync("wsReportHour", new object[] {
                    User,
                    Password,
                    CPCode,
                    timeReport}, this.wsReportHourOperationCompleted, userState);
    }

    private void OnwsReportHourOperationCompleted(object arg)
    {
        if ((this.wsReportHourCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.wsReportHourCompleted(this, new wsReportHourCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public reportDailyBO[] wsReportDaily([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string startDate, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string endDate)
    {
        object[] results = this.Invoke("wsReportDaily", new object[] {
                    User,
                    Password,
                    CPCode,
                    startDate,
                    endDate});
        return ((reportDailyBO[])(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginwsReportDaily(string User, string Password, string CPCode, string startDate, string endDate, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("wsReportDaily", new object[] {
                    User,
                    Password,
                    CPCode,
                    startDate,
                    endDate}, callback, asyncState);
    }

    /// <remarks/>
    public reportDailyBO[] EndwsReportDaily(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((reportDailyBO[])(results[0]));
    }

    /// <remarks/>
    public void wsReportDailyAsync(string User, string Password, string CPCode, string startDate, string endDate)
    {
        this.wsReportDailyAsync(User, Password, CPCode, startDate, endDate, null);
    }

    /// <remarks/>
    public void wsReportDailyAsync(string User, string Password, string CPCode, string startDate, string endDate, object userState)
    {
        if ((this.wsReportDailyOperationCompleted == null))
        {
            this.wsReportDailyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsReportDailyOperationCompleted);
        }
        this.InvokeAsync("wsReportDaily", new object[] {
                    User,
                    Password,
                    CPCode,
                    startDate,
                    endDate}, this.wsReportDailyOperationCompleted, userState);
    }

    private void OnwsReportDailyOperationCompleted(object arg)
    {
        if ((this.wsReportDailyCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.wsReportDailyCompleted(this, new wsReportDailyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public reportMonthBO[] wsReportMonth([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string startMonth, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string endMonth)
    {
        object[] results = this.Invoke("wsReportMonth", new object[] {
                    User,
                    Password,
                    CPCode,
                    startMonth,
                    endMonth});
        return ((reportMonthBO[])(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginwsReportMonth(string User, string Password, string CPCode, string startMonth, string endMonth, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("wsReportMonth", new object[] {
                    User,
                    Password,
                    CPCode,
                    startMonth,
                    endMonth}, callback, asyncState);
    }

    /// <remarks/>
    public reportMonthBO[] EndwsReportMonth(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((reportMonthBO[])(results[0]));
    }

    /// <remarks/>
    public void wsReportMonthAsync(string User, string Password, string CPCode, string startMonth, string endMonth)
    {
        this.wsReportMonthAsync(User, Password, CPCode, startMonth, endMonth, null);
    }

    /// <remarks/>
    public void wsReportMonthAsync(string User, string Password, string CPCode, string startMonth, string endMonth, object userState)
    {
        if ((this.wsReportMonthOperationCompleted == null))
        {
            this.wsReportMonthOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsReportMonthOperationCompleted);
        }
        this.InvokeAsync("wsReportMonth", new object[] {
                    User,
                    Password,
                    CPCode,
                    startMonth,
                    endMonth}, this.wsReportMonthOperationCompleted, userState);
    }

    private void OnwsReportMonthOperationCompleted(object arg)
    {
        if ((this.wsReportMonthCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.wsReportMonthCompleted(this, new wsReportMonthCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public result wsCpMt2([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string RequestID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string UserID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ReceiverID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ServiceID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CommandCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Content, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ContentType, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string senderCpCode)
    {
        object[] results = this.Invoke("wsCpMt2", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType,
                    senderCpCode});
        return ((result)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginwsCpMt2(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType, string senderCpCode, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("wsCpMt2", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType,
                    senderCpCode}, callback, asyncState);
    }

    /// <remarks/>
    public result EndwsCpMt2(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((result)(results[0]));
    }

    /// <remarks/>
    public void wsCpMt2Async(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType, string senderCpCode)
    {
        this.wsCpMt2Async(User, Password, CPCode, RequestID, UserID, ReceiverID, ServiceID, CommandCode, Content, ContentType, senderCpCode, null);
    }

    /// <remarks/>
    public void wsCpMt2Async(string User, string Password, string CPCode, string RequestID, string UserID, string ReceiverID, string ServiceID, string CommandCode, string Content, string ContentType, string senderCpCode, object userState)
    {
        if ((this.wsCpMt2OperationCompleted == null))
        {
            this.wsCpMt2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsCpMt2OperationCompleted);
        }
        this.InvokeAsync("wsCpMt2", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    UserID,
                    ReceiverID,
                    ServiceID,
                    CommandCode,
                    Content,
                    ContentType,
                    senderCpCode}, this.wsCpMt2OperationCompleted, userState);
    }

    private void OnwsCpMt2OperationCompleted(object arg)
    {
        if ((this.wsCpMt2Completed != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.wsCpMt2Completed(this, new wsCpMt2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public resultMultiReceiver wsCpMt4([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string RequestID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ServiceID, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CommandCode, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string ContentType, [System.Xml.Serialization.XmlElementAttribute("Msg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] msgRequest[] Msg)
    {
        object[] results = this.Invoke("wsCpMt4", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    ServiceID,
                    CommandCode,
                    ContentType,
                    Msg});
        return ((resultMultiReceiver)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginwsCpMt4(string User, string Password, string CPCode, string RequestID, string ServiceID, string CommandCode, string ContentType, msgRequest[] Msg, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("wsCpMt4", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    ServiceID,
                    CommandCode,
                    ContentType,
                    Msg}, callback, asyncState);
    }

    /// <remarks/>
    public resultMultiReceiver EndwsCpMt4(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((resultMultiReceiver)(results[0]));
    }

    /// <remarks/>
    public void wsCpMt4Async(string User, string Password, string CPCode, string RequestID, string ServiceID, string CommandCode, string ContentType, msgRequest[] Msg)
    {
        this.wsCpMt4Async(User, Password, CPCode, RequestID, ServiceID, CommandCode, ContentType, Msg, null);
    }

    /// <remarks/>
    public void wsCpMt4Async(string User, string Password, string CPCode, string RequestID, string ServiceID, string CommandCode, string ContentType, msgRequest[] Msg, object userState)
    {
        if ((this.wsCpMt4OperationCompleted == null))
        {
            this.wsCpMt4OperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsCpMt4OperationCompleted);
        }
        this.InvokeAsync("wsCpMt4", new object[] {
                    User,
                    Password,
                    CPCode,
                    RequestID,
                    ServiceID,
                    CommandCode,
                    ContentType,
                    Msg}, this.wsCpMt4OperationCompleted, userState);
    }

    private void OnwsCpMt4OperationCompleted(object arg)
    {
        if ((this.wsCpMt4Completed != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.wsCpMt4Completed(this, new wsCpMt4CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public cpBalance checkBalance([System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string User, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string Password, [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)] string CPCode)
    {
        object[] results = this.Invoke("checkBalance", new object[] {
                    User,
                    Password,
                    CPCode});
        return ((cpBalance)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegincheckBalance(string User, string Password, string CPCode, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("checkBalance", new object[] {
                    User,
                    Password,
                    CPCode}, callback, asyncState);
    }

    /// <remarks/>
    public cpBalance EndcheckBalance(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((cpBalance)(results[0]));
    }

    /// <remarks/>
    public void checkBalanceAsync(string User, string Password, string CPCode)
    {
        this.checkBalanceAsync(User, Password, CPCode, null);
    }

    /// <remarks/>
    public void checkBalanceAsync(string User, string Password, string CPCode, object userState)
    {
        if ((this.checkBalanceOperationCompleted == null))
        {
            this.checkBalanceOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckBalanceOperationCompleted);
        }
        this.InvokeAsync("checkBalance", new object[] {
                    User,
                    Password,
                    CPCode}, this.checkBalanceOperationCompleted, userState);
    }

    private void OncheckBalanceOperationCompleted(object arg)
    {
        if ((this.checkBalanceCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.checkBalanceCompleted(this, new checkBalanceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "http://impl.bulkSms.ws/", ResponseNamespace = "http://impl.bulkSms.ws/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string getIp()
    {
        object[] results = this.Invoke("getIp", new object[0]);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetIp(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getIp", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public string EndgetIp(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void getIpAsync()
    {
        this.getIpAsync(null);
    }

    /// <remarks/>
    public void getIpAsync(object userState)
    {
        if ((this.getIpOperationCompleted == null))
        {
            this.getIpOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetIpOperationCompleted);
        }
        this.InvokeAsync("getIp", new object[0], this.getIpOperationCompleted, userState);
    }

    private void OngetIpOperationCompleted(object arg)
    {
        if ((this.getIpCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getIpCompleted(this, new getIpCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    public new void CancelAsync(object userState)
    {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class resultCp : result
{

    private string[] aliasField;

    private string cpCodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("alias", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public string[] alias
    {
        get
        {
            return this.aliasField;
        }
        set
        {
            this.aliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string cpCode
    {
        get
        {
            return this.cpCodeField;
        }
        set
        {
            this.cpCodeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(resultMultiReceiver))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(resultCp))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class result
{

    private string messageField;

    private long messageIdField;

    private bool messageIdFieldSpecified;

    private long result1Field;

    private bool result1FieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool messageIdSpecified
    {
        get
        {
            return this.messageIdFieldSpecified;
        }
        set
        {
            this.messageIdFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("result", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long result1
    {
        get
        {
            return this.result1Field;
        }
        set
        {
            this.result1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool result1Specified
    {
        get
        {
            return this.result1FieldSpecified;
        }
        set
        {
            this.result1FieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://smsbrand.viettel.com/")]
public partial class cpBalance
{

    private decimal balanceField;

    private bool balanceFieldSpecified;

    private int errCodeField;

    private string errDescField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal balance
    {
        get
        {
            return this.balanceField;
        }
        set
        {
            this.balanceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool balanceSpecified
    {
        get
        {
            return this.balanceFieldSpecified;
        }
        set
        {
            this.balanceFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int errCode
    {
        get
        {
            return this.errCodeField;
        }
        set
        {
            this.errCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string errDesc
    {
        get
        {
            return this.errDescField;
        }
        set
        {
            this.errDescField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class msgRequest
{

    private string messageField;

    private string msgIdField;

    private string receiverField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string msgId
    {
        get
        {
            return this.msgIdField;
        }
        set
        {
            this.msgIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string receiver
    {
        get
        {
            return this.receiverField;
        }
        set
        {
            this.receiverField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class reportMonthBO
{

    private string cpAliasField;

    private string cpCodeField;

    private long cpIdField;

    private bool cpIdFieldSpecified;

    private string messageField;

    private long mtErrorField;

    private bool mtErrorFieldSpecified;

    private long mtErrorAliasField;

    private bool mtErrorAliasFieldSpecified;

    private long mtFailureField;

    private bool mtFailureFieldSpecified;

    private long mtSentField;

    private bool mtSentFieldSpecified;

    private long mtSentOutField;

    private bool mtSentOutFieldSpecified;

    private long mtSentVtField;

    private bool mtSentVtFieldSpecified;

    private string reportMonthField;

    private long reportMonthIdField;

    private bool reportMonthIdFieldSpecified;

    private long resultField;

    private bool resultFieldSpecified;

    private long smsSentField;

    private bool smsSentFieldSpecified;

    private long smsSentOutField;

    private bool smsSentOutFieldSpecified;

    private long smsSentVtField;

    private bool smsSentVtFieldSpecified;

    private long sumMTField;

    private bool sumMTFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string cpAlias
    {
        get
        {
            return this.cpAliasField;
        }
        set
        {
            this.cpAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string cpCode
    {
        get
        {
            return this.cpCodeField;
        }
        set
        {
            this.cpCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long cpId
    {
        get
        {
            return this.cpIdField;
        }
        set
        {
            this.cpIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cpIdSpecified
    {
        get
        {
            return this.cpIdFieldSpecified;
        }
        set
        {
            this.cpIdFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtError
    {
        get
        {
            return this.mtErrorField;
        }
        set
        {
            this.mtErrorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtErrorSpecified
    {
        get
        {
            return this.mtErrorFieldSpecified;
        }
        set
        {
            this.mtErrorFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtErrorAlias
    {
        get
        {
            return this.mtErrorAliasField;
        }
        set
        {
            this.mtErrorAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtErrorAliasSpecified
    {
        get
        {
            return this.mtErrorAliasFieldSpecified;
        }
        set
        {
            this.mtErrorAliasFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtFailure
    {
        get
        {
            return this.mtFailureField;
        }
        set
        {
            this.mtFailureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtFailureSpecified
    {
        get
        {
            return this.mtFailureFieldSpecified;
        }
        set
        {
            this.mtFailureFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtSent
    {
        get
        {
            return this.mtSentField;
        }
        set
        {
            this.mtSentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtSentSpecified
    {
        get
        {
            return this.mtSentFieldSpecified;
        }
        set
        {
            this.mtSentFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtSentOut
    {
        get
        {
            return this.mtSentOutField;
        }
        set
        {
            this.mtSentOutField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtSentOutSpecified
    {
        get
        {
            return this.mtSentOutFieldSpecified;
        }
        set
        {
            this.mtSentOutFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtSentVt
    {
        get
        {
            return this.mtSentVtField;
        }
        set
        {
            this.mtSentVtField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtSentVtSpecified
    {
        get
        {
            return this.mtSentVtFieldSpecified;
        }
        set
        {
            this.mtSentVtFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reportMonth
    {
        get
        {
            return this.reportMonthField;
        }
        set
        {
            this.reportMonthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long reportMonthId
    {
        get
        {
            return this.reportMonthIdField;
        }
        set
        {
            this.reportMonthIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool reportMonthIdSpecified
    {
        get
        {
            return this.reportMonthIdFieldSpecified;
        }
        set
        {
            this.reportMonthIdFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool resultSpecified
    {
        get
        {
            return this.resultFieldSpecified;
        }
        set
        {
            this.resultFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long smsSent
    {
        get
        {
            return this.smsSentField;
        }
        set
        {
            this.smsSentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool smsSentSpecified
    {
        get
        {
            return this.smsSentFieldSpecified;
        }
        set
        {
            this.smsSentFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long smsSentOut
    {
        get
        {
            return this.smsSentOutField;
        }
        set
        {
            this.smsSentOutField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool smsSentOutSpecified
    {
        get
        {
            return this.smsSentOutFieldSpecified;
        }
        set
        {
            this.smsSentOutFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long smsSentVt
    {
        get
        {
            return this.smsSentVtField;
        }
        set
        {
            this.smsSentVtField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool smsSentVtSpecified
    {
        get
        {
            return this.smsSentVtFieldSpecified;
        }
        set
        {
            this.smsSentVtFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long sumMT
    {
        get
        {
            return this.sumMTField;
        }
        set
        {
            this.sumMTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sumMTSpecified
    {
        get
        {
            return this.sumMTFieldSpecified;
        }
        set
        {
            this.sumMTFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class reportDailyBO
{

    private string cpAliasField;

    private string cpCodeField;

    private long cpIdField;

    private bool cpIdFieldSpecified;

    private string messageField;

    private long mtErrorField;

    private bool mtErrorFieldSpecified;

    private long mtErrorAliasField;

    private bool mtErrorAliasFieldSpecified;

    private long mtFailureField;

    private bool mtFailureFieldSpecified;

    private long mtSentField;

    private bool mtSentFieldSpecified;

    private long mtSentOutField;

    private bool mtSentOutFieldSpecified;

    private long mtSentVtField;

    private bool mtSentVtFieldSpecified;

    private long reportDailyIdField;

    private bool reportDailyIdFieldSpecified;

    private string reportDateField;

    private long resultField;

    private bool resultFieldSpecified;

    private long smsSentField;

    private bool smsSentFieldSpecified;

    private long smsSentOutField;

    private bool smsSentOutFieldSpecified;

    private long smsSentVtField;

    private bool smsSentVtFieldSpecified;

    private long sumMTField;

    private bool sumMTFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string cpAlias
    {
        get
        {
            return this.cpAliasField;
        }
        set
        {
            this.cpAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string cpCode
    {
        get
        {
            return this.cpCodeField;
        }
        set
        {
            this.cpCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long cpId
    {
        get
        {
            return this.cpIdField;
        }
        set
        {
            this.cpIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cpIdSpecified
    {
        get
        {
            return this.cpIdFieldSpecified;
        }
        set
        {
            this.cpIdFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtError
    {
        get
        {
            return this.mtErrorField;
        }
        set
        {
            this.mtErrorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtErrorSpecified
    {
        get
        {
            return this.mtErrorFieldSpecified;
        }
        set
        {
            this.mtErrorFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtErrorAlias
    {
        get
        {
            return this.mtErrorAliasField;
        }
        set
        {
            this.mtErrorAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtErrorAliasSpecified
    {
        get
        {
            return this.mtErrorAliasFieldSpecified;
        }
        set
        {
            this.mtErrorAliasFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtFailure
    {
        get
        {
            return this.mtFailureField;
        }
        set
        {
            this.mtFailureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtFailureSpecified
    {
        get
        {
            return this.mtFailureFieldSpecified;
        }
        set
        {
            this.mtFailureFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtSent
    {
        get
        {
            return this.mtSentField;
        }
        set
        {
            this.mtSentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtSentSpecified
    {
        get
        {
            return this.mtSentFieldSpecified;
        }
        set
        {
            this.mtSentFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtSentOut
    {
        get
        {
            return this.mtSentOutField;
        }
        set
        {
            this.mtSentOutField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtSentOutSpecified
    {
        get
        {
            return this.mtSentOutFieldSpecified;
        }
        set
        {
            this.mtSentOutFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtSentVt
    {
        get
        {
            return this.mtSentVtField;
        }
        set
        {
            this.mtSentVtField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtSentVtSpecified
    {
        get
        {
            return this.mtSentVtFieldSpecified;
        }
        set
        {
            this.mtSentVtFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long reportDailyId
    {
        get
        {
            return this.reportDailyIdField;
        }
        set
        {
            this.reportDailyIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool reportDailyIdSpecified
    {
        get
        {
            return this.reportDailyIdFieldSpecified;
        }
        set
        {
            this.reportDailyIdFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reportDate
    {
        get
        {
            return this.reportDateField;
        }
        set
        {
            this.reportDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool resultSpecified
    {
        get
        {
            return this.resultFieldSpecified;
        }
        set
        {
            this.resultFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long smsSent
    {
        get
        {
            return this.smsSentField;
        }
        set
        {
            this.smsSentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool smsSentSpecified
    {
        get
        {
            return this.smsSentFieldSpecified;
        }
        set
        {
            this.smsSentFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long smsSentOut
    {
        get
        {
            return this.smsSentOutField;
        }
        set
        {
            this.smsSentOutField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool smsSentOutSpecified
    {
        get
        {
            return this.smsSentOutFieldSpecified;
        }
        set
        {
            this.smsSentOutFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long smsSentVt
    {
        get
        {
            return this.smsSentVtField;
        }
        set
        {
            this.smsSentVtField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool smsSentVtSpecified
    {
        get
        {
            return this.smsSentVtFieldSpecified;
        }
        set
        {
            this.smsSentVtFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long sumMT
    {
        get
        {
            return this.sumMTField;
        }
        set
        {
            this.sumMTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sumMTSpecified
    {
        get
        {
            return this.sumMTFieldSpecified;
        }
        set
        {
            this.sumMTFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class reportHourBO
{

    private string cpAliasField;

    private string cpCodeField;

    private long cpIdField;

    private bool cpIdFieldSpecified;

    private string messageField;

    private long mtErrorField;

    private bool mtErrorFieldSpecified;

    private long mtErrorAliasField;

    private bool mtErrorAliasFieldSpecified;

    private long mtFailureField;

    private bool mtFailureFieldSpecified;

    private long mtSentField;

    private bool mtSentFieldSpecified;

    private long mtSentOutField;

    private bool mtSentOutFieldSpecified;

    private long mtSentVtField;

    private bool mtSentVtFieldSpecified;

    private string reportHourField;

    private long reportHourIdField;

    private bool reportHourIdFieldSpecified;

    private long resultField;

    private bool resultFieldSpecified;

    private long smsSentField;

    private bool smsSentFieldSpecified;

    private long smsSentOutField;

    private bool smsSentOutFieldSpecified;

    private long smsSentVtField;

    private bool smsSentVtFieldSpecified;

    private long sumMTField;

    private bool sumMTFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string cpAlias
    {
        get
        {
            return this.cpAliasField;
        }
        set
        {
            this.cpAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string cpCode
    {
        get
        {
            return this.cpCodeField;
        }
        set
        {
            this.cpCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long cpId
    {
        get
        {
            return this.cpIdField;
        }
        set
        {
            this.cpIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cpIdSpecified
    {
        get
        {
            return this.cpIdFieldSpecified;
        }
        set
        {
            this.cpIdFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtError
    {
        get
        {
            return this.mtErrorField;
        }
        set
        {
            this.mtErrorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtErrorSpecified
    {
        get
        {
            return this.mtErrorFieldSpecified;
        }
        set
        {
            this.mtErrorFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtErrorAlias
    {
        get
        {
            return this.mtErrorAliasField;
        }
        set
        {
            this.mtErrorAliasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtErrorAliasSpecified
    {
        get
        {
            return this.mtErrorAliasFieldSpecified;
        }
        set
        {
            this.mtErrorAliasFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtFailure
    {
        get
        {
            return this.mtFailureField;
        }
        set
        {
            this.mtFailureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtFailureSpecified
    {
        get
        {
            return this.mtFailureFieldSpecified;
        }
        set
        {
            this.mtFailureFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtSent
    {
        get
        {
            return this.mtSentField;
        }
        set
        {
            this.mtSentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtSentSpecified
    {
        get
        {
            return this.mtSentFieldSpecified;
        }
        set
        {
            this.mtSentFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtSentOut
    {
        get
        {
            return this.mtSentOutField;
        }
        set
        {
            this.mtSentOutField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtSentOutSpecified
    {
        get
        {
            return this.mtSentOutFieldSpecified;
        }
        set
        {
            this.mtSentOutFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long mtSentVt
    {
        get
        {
            return this.mtSentVtField;
        }
        set
        {
            this.mtSentVtField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtSentVtSpecified
    {
        get
        {
            return this.mtSentVtFieldSpecified;
        }
        set
        {
            this.mtSentVtFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string reportHour
    {
        get
        {
            return this.reportHourField;
        }
        set
        {
            this.reportHourField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long reportHourId
    {
        get
        {
            return this.reportHourIdField;
        }
        set
        {
            this.reportHourIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool reportHourIdSpecified
    {
        get
        {
            return this.reportHourIdFieldSpecified;
        }
        set
        {
            this.reportHourIdFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool resultSpecified
    {
        get
        {
            return this.resultFieldSpecified;
        }
        set
        {
            this.resultFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long smsSent
    {
        get
        {
            return this.smsSentField;
        }
        set
        {
            this.smsSentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool smsSentSpecified
    {
        get
        {
            return this.smsSentFieldSpecified;
        }
        set
        {
            this.smsSentFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long smsSentOut
    {
        get
        {
            return this.smsSentOutField;
        }
        set
        {
            this.smsSentOutField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool smsSentOutSpecified
    {
        get
        {
            return this.smsSentOutFieldSpecified;
        }
        set
        {
            this.smsSentOutFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long smsSentVt
    {
        get
        {
            return this.smsSentVtField;
        }
        set
        {
            this.smsSentVtField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool smsSentVtSpecified
    {
        get
        {
            return this.smsSentVtFieldSpecified;
        }
        set
        {
            this.smsSentVtFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long sumMT
    {
        get
        {
            return this.sumMTField;
        }
        set
        {
            this.sumMTField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sumMTSpecified
    {
        get
        {
            return this.sumMTFieldSpecified;
        }
        set
        {
            this.sumMTFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class resultDlrDetail
{

    private int dlrStatusField;

    private long messageIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int dlrStatus
    {
        get
        {
            return this.dlrStatusField;
        }
        set
        {
            this.dlrStatusField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class resultDlr
{

    private resultDlrDetail[] detailsField;

    private string messageField;

    private long resultField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("details", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public resultDlrDetail[] details
    {
        get
        {
            return this.detailsField;
        }
        set
        {
            this.detailsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class responseMt
{

    private string messageField;

    private string requestIdField;

    private long resultField;

    private bool resultFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string requestId
    {
        get
        {
            return this.requestIdField;
        }
        set
        {
            this.requestIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool resultSpecified
    {
        get
        {
            return this.resultFieldSpecified;
        }
        set
        {
            this.resultFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class createMtResult
{

    private long errCodeField;

    private string errDescField;

    private responseMt[] responseMtField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long errCode
    {
        get
        {
            return this.errCodeField;
        }
        set
        {
            this.errCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string errDesc
    {
        get
        {
            return this.errDescField;
        }
        set
        {
            this.errDescField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("responseMt")]
    public responseMt[] responseMt
    {
        get
        {
            return this.responseMtField;
        }
        set
        {
            this.responseMtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class requestMt
{

    private string contentField;

    private long contentTypeField;

    private string receiverIDField;

    private string requestIDField;

    private string serviceIDField;

    private string userIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string content
    {
        get
        {
            return this.contentField;
        }
        set
        {
            this.contentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public long contentType
    {
        get
        {
            return this.contentTypeField;
        }
        set
        {
            this.contentTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string receiverID
    {
        get
        {
            return this.receiverIDField;
        }
        set
        {
            this.receiverIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string requestID
    {
        get
        {
            return this.requestIDField;
        }
        set
        {
            this.requestIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string serviceID
    {
        get
        {
            return this.serviceIDField;
        }
        set
        {
            this.serviceIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string userID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class failSub
{

    private string receiverField;

    private string messageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string receiver
    {
        get
        {
            return this.receiverField;
        }
        set
        {
            this.receiverField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class failSubReponse
{

    private string errorCodeField;

    private string messageField;

    private failSub[] resultField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string errorCode
    {
        get
        {
            return this.errorCodeField;
        }
        set
        {
            this.errorCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("result", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public failSub[] result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://impl.bulkSms.ws/")]
public partial class resultMultiReceiver : result
{

    private resultMultiReceiver[] detailsField;

    private string msgIdField;

    private string receiverField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("details", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public resultMultiReceiver[] details
    {
        get
        {
            return this.detailsField;
        }
        set
        {
            this.detailsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string msgId
    {
        get
        {
            return this.msgIdField;
        }
        set
        {
            this.msgIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string receiver
    {
        get
        {
            return this.receiverField;
        }
        set
        {
            this.receiverField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void wsGetCpCodeCompletedEventHandler(object sender, wsGetCpCodeCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class wsGetCpCodeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal wsGetCpCodeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public resultCp Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((resultCp)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getFailSubCompletedEventHandler(object sender, getFailSubCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getFailSubCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getFailSubCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public failSubReponse Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((failSubReponse)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void wsCpBatchMtCompletedEventHandler(object sender, wsCpBatchMtCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class wsCpBatchMtCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal wsCpBatchMtCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public createMtResult Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((createMtResult)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void wsEcomCpMtCompletedEventHandler(object sender, wsEcomCpMtCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class wsEcomCpMtCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal wsEcomCpMtCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public result Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((result)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void wsCpMtRegDlrCompletedEventHandler(object sender, wsCpMtRegDlrCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class wsCpMtRegDlrCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal wsCpMtRegDlrCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public result Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((result)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getDlrStatusCompletedEventHandler(object sender, getDlrStatusCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getDlrStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getDlrStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public resultDlr Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((resultDlr)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void wsCpMtCompletedEventHandler(object sender, wsCpMtCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class wsCpMtCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal wsCpMtCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public result Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((result)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void wsReportHourCompletedEventHandler(object sender, wsReportHourCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class wsReportHourCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal wsReportHourCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public reportHourBO[] Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((reportHourBO[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void wsReportDailyCompletedEventHandler(object sender, wsReportDailyCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class wsReportDailyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal wsReportDailyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public reportDailyBO[] Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((reportDailyBO[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void wsReportMonthCompletedEventHandler(object sender, wsReportMonthCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class wsReportMonthCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal wsReportMonthCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public reportMonthBO[] Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((reportMonthBO[])(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void wsCpMt2CompletedEventHandler(object sender, wsCpMt2CompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class wsCpMt2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal wsCpMt2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public result Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((result)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void wsCpMt4CompletedEventHandler(object sender, wsCpMt4CompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class wsCpMt4CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal wsCpMt4CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public resultMultiReceiver Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((resultMultiReceiver)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void checkBalanceCompletedEventHandler(object sender, checkBalanceCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class checkBalanceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal checkBalanceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public cpBalance Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((cpBalance)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getIpCompletedEventHandler(object sender, getIpCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getIpCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getIpCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
