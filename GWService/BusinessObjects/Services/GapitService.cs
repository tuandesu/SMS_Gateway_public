/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "JetNavSMSSoap", Namespace = "http://tempuri.org/")]
public partial class JetNavSMS : System.Web.Services.Protocols.SoapHttpClientProtocol
{

    private System.Threading.SendOrPostCallback createProgOperationCompleted;

    private System.Threading.SendOrPostCallback updateProgOperationCompleted;

    private System.Threading.SendOrPostCallback deleteProgOperationCompleted;

    private System.Threading.SendOrPostCallback uploadMsisdnsOperationCompleted;

    private System.Threading.SendOrPostCallback getDailyProgReportOperationCompleted;

    private System.Threading.SendOrPostCallback getDailySmsReportOperationCompleted;

    private System.Threading.SendOrPostCallback getMonthProgReportOperationCompleted;

    private System.Threading.SendOrPostCallback getMonthSmsReportOperationCompleted;

    private System.Threading.SendOrPostCallback getYearProgReportOperationCompleted;

    private System.Threading.SendOrPostCallback getYearSmsReportOperationCompleted;

    private System.Threading.SendOrPostCallback SendMTOperationCompleted;

    /// <remarks/>
    public JetNavSMS()
    {
        this.Url = "http://brandname.gapit.com.vn/delivery/jetnavsms.asmx";
    }

    /// <remarks/>
    public event createProgCompletedEventHandler createProgCompleted;

    /// <remarks/>
    public event updateProgCompletedEventHandler updateProgCompleted;

    /// <remarks/>
    public event deleteProgCompletedEventHandler deleteProgCompleted;

    /// <remarks/>
    public event uploadMsisdnsCompletedEventHandler uploadMsisdnsCompleted;

    /// <remarks/>
    public event getDailyProgReportCompletedEventHandler getDailyProgReportCompleted;

    /// <remarks/>
    public event getDailySmsReportCompletedEventHandler getDailySmsReportCompleted;

    /// <remarks/>
    public event getMonthProgReportCompletedEventHandler getMonthProgReportCompleted;

    /// <remarks/>
    public event getMonthSmsReportCompletedEventHandler getMonthSmsReportCompleted;

    /// <remarks/>
    public event getYearProgReportCompletedEventHandler getYearProgReportCompleted;

    /// <remarks/>
    public event getYearSmsReportCompletedEventHandler getYearSmsReportCompleted;

    /// <remarks/>
    public event SendMTCompletedEventHandler SendMTCompleted;

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/createProg", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public AdProg createProg(authenUser authen, AdProg tmpProg)
    {
        object[] results = this.Invoke("createProg", new object[] {
                        authen,
                        tmpProg});
        return ((AdProg)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegincreateProg(authenUser authen, AdProg tmpProg, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("createProg", new object[] {
                        authen,
                        tmpProg}, callback, asyncState);
    }

    /// <remarks/>
    public AdProg EndcreateProg(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((AdProg)(results[0]));
    }

    /// <remarks/>
    public void createProgAsync(authenUser authen, AdProg tmpProg)
    {
        this.createProgAsync(authen, tmpProg, null);
    }

    /// <remarks/>
    public void createProgAsync(authenUser authen, AdProg tmpProg, object userState)
    {
        if ((this.createProgOperationCompleted == null))
        {
            this.createProgOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateProgOperationCompleted);
        }
        this.InvokeAsync("createProg", new object[] {
                        authen,
                        tmpProg}, this.createProgOperationCompleted, userState);
    }

    private void OncreateProgOperationCompleted(object arg)
    {
        if ((this.createProgCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.createProgCompleted(this, new createProgCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateProg", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public AdProg updateProg(authenUser authen, AdProg tmpProg)
    {
        object[] results = this.Invoke("updateProg", new object[] {
                        authen,
                        tmpProg});
        return ((AdProg)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginupdateProg(authenUser authen, AdProg tmpProg, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("updateProg", new object[] {
                        authen,
                        tmpProg}, callback, asyncState);
    }

    /// <remarks/>
    public AdProg EndupdateProg(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((AdProg)(results[0]));
    }

    /// <remarks/>
    public void updateProgAsync(authenUser authen, AdProg tmpProg)
    {
        this.updateProgAsync(authen, tmpProg, null);
    }

    /// <remarks/>
    public void updateProgAsync(authenUser authen, AdProg tmpProg, object userState)
    {
        if ((this.updateProgOperationCompleted == null))
        {
            this.updateProgOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateProgOperationCompleted);
        }
        this.InvokeAsync("updateProg", new object[] {
                        authen,
                        tmpProg}, this.updateProgOperationCompleted, userState);
    }

    private void OnupdateProgOperationCompleted(object arg)
    {
        if ((this.updateProgCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.updateProgCompleted(this, new updateProgCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/deleteProg", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int deleteProg(authenUser authen, string progCode)
    {
        object[] results = this.Invoke("deleteProg", new object[] {
                        authen,
                        progCode});
        return ((int)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegindeleteProg(authenUser authen, string progCode, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("deleteProg", new object[] {
                        authen,
                        progCode}, callback, asyncState);
    }

    /// <remarks/>
    public int EnddeleteProg(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks/>
    public void deleteProgAsync(authenUser authen, string progCode)
    {
        this.deleteProgAsync(authen, progCode, null);
    }

    /// <remarks/>
    public void deleteProgAsync(authenUser authen, string progCode, object userState)
    {
        if ((this.deleteProgOperationCompleted == null))
        {
            this.deleteProgOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteProgOperationCompleted);
        }
        this.InvokeAsync("deleteProg", new object[] {
                        authen,
                        progCode}, this.deleteProgOperationCompleted, userState);
    }

    private void OndeleteProgOperationCompleted(object arg)
    {
        if ((this.deleteProgCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.deleteProgCompleted(this, new deleteProgCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/uploadMsisdns", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int uploadMsisdns(authenUser authen, string progCode, string[] msisdns)
    {
        object[] results = this.Invoke("uploadMsisdns", new object[] {
                        authen,
                        progCode,
                        msisdns});
        return ((int)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginuploadMsisdns(authenUser authen, string progCode, string[] msisdns, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("uploadMsisdns", new object[] {
                        authen,
                        progCode,
                        msisdns}, callback, asyncState);
    }

    /// <remarks/>
    public int EnduploadMsisdns(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks/>
    public void uploadMsisdnsAsync(authenUser authen, string progCode, string[] msisdns)
    {
        this.uploadMsisdnsAsync(authen, progCode, msisdns, null);
    }

    /// <remarks/>
    public void uploadMsisdnsAsync(authenUser authen, string progCode, string[] msisdns, object userState)
    {
        if ((this.uploadMsisdnsOperationCompleted == null))
        {
            this.uploadMsisdnsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnuploadMsisdnsOperationCompleted);
        }
        this.InvokeAsync("uploadMsisdns", new object[] {
                        authen,
                        progCode,
                        msisdns}, this.uploadMsisdnsOperationCompleted, userState);
    }

    private void OnuploadMsisdnsOperationCompleted(object arg)
    {
        if ((this.uploadMsisdnsCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.uploadMsisdnsCompleted(this, new uploadMsisdnsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getDailyProgReport", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public progReport getDailyProgReport(authenUser authen, string catCode, string fromDate, string toDate)
    {
        object[] results = this.Invoke("getDailyProgReport", new object[] {
                        authen,
                        catCode,
                        fromDate,
                        toDate});
        return ((progReport)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetDailyProgReport(authenUser authen, string catCode, string fromDate, string toDate, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getDailyProgReport", new object[] {
                        authen,
                        catCode,
                        fromDate,
                        toDate}, callback, asyncState);
    }

    /// <remarks/>
    public progReport EndgetDailyProgReport(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((progReport)(results[0]));
    }

    /// <remarks/>
    public void getDailyProgReportAsync(authenUser authen, string catCode, string fromDate, string toDate)
    {
        this.getDailyProgReportAsync(authen, catCode, fromDate, toDate, null);
    }

    /// <remarks/>
    public void getDailyProgReportAsync(authenUser authen, string catCode, string fromDate, string toDate, object userState)
    {
        if ((this.getDailyProgReportOperationCompleted == null))
        {
            this.getDailyProgReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDailyProgReportOperationCompleted);
        }
        this.InvokeAsync("getDailyProgReport", new object[] {
                        authen,
                        catCode,
                        fromDate,
                        toDate}, this.getDailyProgReportOperationCompleted, userState);
    }

    private void OngetDailyProgReportOperationCompleted(object arg)
    {
        if ((this.getDailyProgReportCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getDailyProgReportCompleted(this, new getDailyProgReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getDailySmsReport", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public smsReport getDailySmsReport(authenUser authen, string progCode, string catCode, string fromDate, string toDate)
    {
        object[] results = this.Invoke("getDailySmsReport", new object[] {
                        authen,
                        progCode,
                        catCode,
                        fromDate,
                        toDate});
        return ((smsReport)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetDailySmsReport(authenUser authen, string progCode, string catCode, string fromDate, string toDate, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getDailySmsReport", new object[] {
                        authen,
                        progCode,
                        catCode,
                        fromDate,
                        toDate}, callback, asyncState);
    }

    /// <remarks/>
    public smsReport EndgetDailySmsReport(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((smsReport)(results[0]));
    }

    /// <remarks/>
    public void getDailySmsReportAsync(authenUser authen, string progCode, string catCode, string fromDate, string toDate)
    {
        this.getDailySmsReportAsync(authen, progCode, catCode, fromDate, toDate, null);
    }

    /// <remarks/>
    public void getDailySmsReportAsync(authenUser authen, string progCode, string catCode, string fromDate, string toDate, object userState)
    {
        if ((this.getDailySmsReportOperationCompleted == null))
        {
            this.getDailySmsReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetDailySmsReportOperationCompleted);
        }
        this.InvokeAsync("getDailySmsReport", new object[] {
                        authen,
                        progCode,
                        catCode,
                        fromDate,
                        toDate}, this.getDailySmsReportOperationCompleted, userState);
    }

    private void OngetDailySmsReportOperationCompleted(object arg)
    {
        if ((this.getDailySmsReportCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getDailySmsReportCompleted(this, new getDailySmsReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getMonthProgReport", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public progReport getMonthProgReport(authenUser authen, string catCode, string month)
    {
        object[] results = this.Invoke("getMonthProgReport", new object[] {
                        authen,
                        catCode,
                        month});
        return ((progReport)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetMonthProgReport(authenUser authen, string catCode, string month, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getMonthProgReport", new object[] {
                        authen,
                        catCode,
                        month}, callback, asyncState);
    }

    /// <remarks/>
    public progReport EndgetMonthProgReport(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((progReport)(results[0]));
    }

    /// <remarks/>
    public void getMonthProgReportAsync(authenUser authen, string catCode, string month)
    {
        this.getMonthProgReportAsync(authen, catCode, month, null);
    }

    /// <remarks/>
    public void getMonthProgReportAsync(authenUser authen, string catCode, string month, object userState)
    {
        if ((this.getMonthProgReportOperationCompleted == null))
        {
            this.getMonthProgReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetMonthProgReportOperationCompleted);
        }
        this.InvokeAsync("getMonthProgReport", new object[] {
                        authen,
                        catCode,
                        month}, this.getMonthProgReportOperationCompleted, userState);
    }

    private void OngetMonthProgReportOperationCompleted(object arg)
    {
        if ((this.getMonthProgReportCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getMonthProgReportCompleted(this, new getMonthProgReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getMonthSmsReport", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public smsReport getMonthSmsReport(authenUser authen, string progCode, string catCode, string month)
    {
        object[] results = this.Invoke("getMonthSmsReport", new object[] {
                        authen,
                        progCode,
                        catCode,
                        month});
        return ((smsReport)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetMonthSmsReport(authenUser authen, string progCode, string catCode, string month, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getMonthSmsReport", new object[] {
                        authen,
                        progCode,
                        catCode,
                        month}, callback, asyncState);
    }

    /// <remarks/>
    public smsReport EndgetMonthSmsReport(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((smsReport)(results[0]));
    }

    /// <remarks/>
    public void getMonthSmsReportAsync(authenUser authen, string progCode, string catCode, string month)
    {
        this.getMonthSmsReportAsync(authen, progCode, catCode, month, null);
    }

    /// <remarks/>
    public void getMonthSmsReportAsync(authenUser authen, string progCode, string catCode, string month, object userState)
    {
        if ((this.getMonthSmsReportOperationCompleted == null))
        {
            this.getMonthSmsReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetMonthSmsReportOperationCompleted);
        }
        this.InvokeAsync("getMonthSmsReport", new object[] {
                        authen,
                        progCode,
                        catCode,
                        month}, this.getMonthSmsReportOperationCompleted, userState);
    }

    private void OngetMonthSmsReportOperationCompleted(object arg)
    {
        if ((this.getMonthSmsReportCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getMonthSmsReportCompleted(this, new getMonthSmsReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getYearProgReport", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public progReport getYearProgReport(authenUser authen, string catCode, string year)
    {
        object[] results = this.Invoke("getYearProgReport", new object[] {
                        authen,
                        catCode,
                        year});
        return ((progReport)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetYearProgReport(authenUser authen, string catCode, string year, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getYearProgReport", new object[] {
                        authen,
                        catCode,
                        year}, callback, asyncState);
    }

    /// <remarks/>
    public progReport EndgetYearProgReport(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((progReport)(results[0]));
    }

    /// <remarks/>
    public void getYearProgReportAsync(authenUser authen, string catCode, string year)
    {
        this.getYearProgReportAsync(authen, catCode, year, null);
    }

    /// <remarks/>
    public void getYearProgReportAsync(authenUser authen, string catCode, string year, object userState)
    {
        if ((this.getYearProgReportOperationCompleted == null))
        {
            this.getYearProgReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetYearProgReportOperationCompleted);
        }
        this.InvokeAsync("getYearProgReport", new object[] {
                        authen,
                        catCode,
                        year}, this.getYearProgReportOperationCompleted, userState);
    }

    private void OngetYearProgReportOperationCompleted(object arg)
    {
        if ((this.getYearProgReportCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getYearProgReportCompleted(this, new getYearProgReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getYearSmsReport", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public smsReport getYearSmsReport(authenUser authen, string progCode, string catCode, string year)
    {
        object[] results = this.Invoke("getYearSmsReport", new object[] {
                        authen,
                        progCode,
                        catCode,
                        year});
        return ((smsReport)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BegingetYearSmsReport(authenUser authen, string progCode, string catCode, string year, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("getYearSmsReport", new object[] {
                        authen,
                        progCode,
                        catCode,
                        year}, callback, asyncState);
    }

    /// <remarks/>
    public smsReport EndgetYearSmsReport(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((smsReport)(results[0]));
    }

    /// <remarks/>
    public void getYearSmsReportAsync(authenUser authen, string progCode, string catCode, string year)
    {
        this.getYearSmsReportAsync(authen, progCode, catCode, year, null);
    }

    /// <remarks/>
    public void getYearSmsReportAsync(authenUser authen, string progCode, string catCode, string year, object userState)
    {
        if ((this.getYearSmsReportOperationCompleted == null))
        {
            this.getYearSmsReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetYearSmsReportOperationCompleted);
        }
        this.InvokeAsync("getYearSmsReport", new object[] {
                        authen,
                        progCode,
                        catCode,
                        year}, this.getYearSmsReportOperationCompleted, userState);
    }

    private void OngetYearSmsReportOperationCompleted(object arg)
    {
        if ((this.getYearSmsReportCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.getYearSmsReportCompleted(this, new getYearSmsReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendMT", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public int SendMT(string dest, string name, string msgBody, string contentType, string serviceID, long mtID, string cpID, string username, string password)
    {
        object[] results = this.Invoke("SendMT", new object[] {
                        dest,
                        name,
                        msgBody,
                        contentType,
                        serviceID,
                        mtID,
                        cpID,
                        username,
                        password});
        return ((int)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult BeginSendMT(string dest, string name, string msgBody, string contentType, string serviceID, long mtID, string cpID, string username, string password, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("SendMT", new object[] {
                        dest,
                        name,
                        msgBody,
                        contentType,
                        serviceID,
                        mtID,
                        cpID,
                        username,
                        password}, callback, asyncState);
    }

    /// <remarks/>
    public int EndSendMT(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks/>
    public void SendMTAsync(string dest, string name, string msgBody, string contentType, string serviceID, long mtID, string cpID, string username, string password)
    {
        this.SendMTAsync(dest, name, msgBody, contentType, serviceID, mtID, cpID, username, password, null);
    }

    /// <remarks/>
    public void SendMTAsync(string dest, string name, string msgBody, string contentType, string serviceID, long mtID, string cpID, string username, string password, object userState)
    {
        if ((this.SendMTOperationCompleted == null))
        {
            this.SendMTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendMTOperationCompleted);
        }
        this.InvokeAsync("SendMT", new object[] {
                        dest,
                        name,
                        msgBody,
                        contentType,
                        serviceID,
                        mtID,
                        cpID,
                        username,
                        password}, this.SendMTOperationCompleted, userState);
    }

    private void OnSendMTOperationCompleted(object arg)
    {
        if ((this.SendMTCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SendMTCompleted(this, new SendMTCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
public partial class authenUser
{

    private int isAdminField;

    private string cpCodeField;

    private string nameField;

    private string passField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int isAdmin
    {
        get
        {
            return this.isAdminField;
        }
        set
        {
            this.isAdminField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string pass
    {
        get
        {
            return this.passField;
        }
        set
        {
            this.passField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
public partial class smsRecord
{

    private string dateField;

    private int moReplyField;

    private int mt1ErrorField;

    private int mt1NotSendField;

    private int mt1SuccessField;

    private int mt2SuccessField;

    private int numOderField;

    private int sms1SuccessField;

    private int sms2SuccessField;

    private int subUnRegField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int moReply
    {
        get
        {
            return this.moReplyField;
        }
        set
        {
            this.moReplyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int mt1Error
    {
        get
        {
            return this.mt1ErrorField;
        }
        set
        {
            this.mt1ErrorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int mt1NotSend
    {
        get
        {
            return this.mt1NotSendField;
        }
        set
        {
            this.mt1NotSendField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int mt1Success
    {
        get
        {
            return this.mt1SuccessField;
        }
        set
        {
            this.mt1SuccessField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int mt2Success
    {
        get
        {
            return this.mt2SuccessField;
        }
        set
        {
            this.mt2SuccessField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int numOder
    {
        get
        {
            return this.numOderField;
        }
        set
        {
            this.numOderField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int sms1Success
    {
        get
        {
            return this.sms1SuccessField;
        }
        set
        {
            this.sms1SuccessField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int sms2Success
    {
        get
        {
            return this.sms2SuccessField;
        }
        set
        {
            this.sms2SuccessField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int subUnReg
    {
        get
        {
            return this.subUnRegField;
        }
        set
        {
            this.subUnRegField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
public partial class smsReport
{

    private smsRecord[] smsRecordsField;

    private int statusField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("smsRecords", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public smsRecord[] smsRecords
    {
        get
        {
            return this.smsRecordsField;
        }
        set
        {
            this.smsRecordsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
public partial class progSmsRecord
{

    private string dateField;

    private int mt1SuccessField;

    private int mt2SuccessField;

    private int progCompleteField;

    private int progCreateField;

    private int progFinishField;

    private int sms1SuccessField;

    private int sms2SuccessField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int mt1Success
    {
        get
        {
            return this.mt1SuccessField;
        }
        set
        {
            this.mt1SuccessField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int mt2Success
    {
        get
        {
            return this.mt2SuccessField;
        }
        set
        {
            this.mt2SuccessField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int progComplete
    {
        get
        {
            return this.progCompleteField;
        }
        set
        {
            this.progCompleteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int progCreate
    {
        get
        {
            return this.progCreateField;
        }
        set
        {
            this.progCreateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int progFinish
    {
        get
        {
            return this.progFinishField;
        }
        set
        {
            this.progFinishField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int sms1Success
    {
        get
        {
            return this.sms1SuccessField;
        }
        set
        {
            this.sms1SuccessField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int sms2Success
    {
        get
        {
            return this.sms2SuccessField;
        }
        set
        {
            this.sms2SuccessField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
public partial class progReport
{

    private progSmsRecord[] progSmsRecordsField;

    private int statusField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("progSmsRecords", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public progSmsRecord[] progSmsRecords
    {
        get
        {
            return this.progSmsRecordsField;
        }
        set
        {
            this.progSmsRecordsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://tempuri.org/")]
public partial class AdProg
{

    private string progCodeField;

    private string categoryField;

    private string contentField;

    private string sentStartDateField;

    private string sentFinishDateField;

    private int maxSmsField;

    private string aliasField;

    private string sentScheduleField;

    private string exceptionDayField;

    private int sentTimeZoneField;

    private string createdUserField;

    private string createdDateField;

    private int priorityField;

    private int statusField;

    private int sentTypeField;

    private string zoneListField;

    private string catListField;

    private int totalSubField;

    private int genderField;

    private int minYearField;

    private int maxYearField;

    private int jobField;

    private int incomeField;

    private int processStatusField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string progCode
    {
        get
        {
            return this.progCodeField;
        }
        set
        {
            this.progCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

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
    public string sentStartDate
    {
        get
        {
            return this.sentStartDateField;
        }
        set
        {
            this.sentStartDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string sentFinishDate
    {
        get
        {
            return this.sentFinishDateField;
        }
        set
        {
            this.sentFinishDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int maxSms
    {
        get
        {
            return this.maxSmsField;
        }
        set
        {
            this.maxSmsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string alias
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
    public string sentSchedule
    {
        get
        {
            return this.sentScheduleField;
        }
        set
        {
            this.sentScheduleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string exceptionDay
    {
        get
        {
            return this.exceptionDayField;
        }
        set
        {
            this.exceptionDayField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int sentTimeZone
    {
        get
        {
            return this.sentTimeZoneField;
        }
        set
        {
            this.sentTimeZoneField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string createdUser
    {
        get
        {
            return this.createdUserField;
        }
        set
        {
            this.createdUserField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string createdDate
    {
        get
        {
            return this.createdDateField;
        }
        set
        {
            this.createdDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int priority
    {
        get
        {
            return this.priorityField;
        }
        set
        {
            this.priorityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int sentType
    {
        get
        {
            return this.sentTypeField;
        }
        set
        {
            this.sentTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string zoneList
    {
        get
        {
            return this.zoneListField;
        }
        set
        {
            this.zoneListField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string catList
    {
        get
        {
            return this.catListField;
        }
        set
        {
            this.catListField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int totalSub
    {
        get
        {
            return this.totalSubField;
        }
        set
        {
            this.totalSubField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int gender
    {
        get
        {
            return this.genderField;
        }
        set
        {
            this.genderField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int minYear
    {
        get
        {
            return this.minYearField;
        }
        set
        {
            this.minYearField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int maxYear
    {
        get
        {
            return this.maxYearField;
        }
        set
        {
            this.maxYearField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int job
    {
        get
        {
            return this.jobField;
        }
        set
        {
            this.jobField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int income
    {
        get
        {
            return this.incomeField;
        }
        set
        {
            this.incomeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int processStatus
    {
        get
        {
            return this.processStatusField;
        }
        set
        {
            this.processStatusField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void createProgCompletedEventHandler(object sender, createProgCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class createProgCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal createProgCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public AdProg Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((AdProg)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void updateProgCompletedEventHandler(object sender, updateProgCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class updateProgCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal updateProgCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public AdProg Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((AdProg)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void deleteProgCompletedEventHandler(object sender, deleteProgCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class deleteProgCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal deleteProgCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void uploadMsisdnsCompletedEventHandler(object sender, uploadMsisdnsCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class uploadMsisdnsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal uploadMsisdnsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getDailyProgReportCompletedEventHandler(object sender, getDailyProgReportCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getDailyProgReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getDailyProgReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public progReport Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((progReport)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getDailySmsReportCompletedEventHandler(object sender, getDailySmsReportCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getDailySmsReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getDailySmsReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public smsReport Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((smsReport)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getMonthProgReportCompletedEventHandler(object sender, getMonthProgReportCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getMonthProgReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getMonthProgReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public progReport Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((progReport)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getMonthSmsReportCompletedEventHandler(object sender, getMonthSmsReportCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getMonthSmsReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getMonthSmsReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public smsReport Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((smsReport)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getYearProgReportCompletedEventHandler(object sender, getYearProgReportCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getYearProgReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getYearProgReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public progReport Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((progReport)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void getYearSmsReportCompletedEventHandler(object sender, getYearSmsReportCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class getYearSmsReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal getYearSmsReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public smsReport Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((smsReport)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void SendMTCompletedEventHandler(object sender, SendMTCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class SendMTCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal SendMTCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
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