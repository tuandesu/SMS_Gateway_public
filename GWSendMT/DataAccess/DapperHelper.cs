using Dapper;
using GWSendMT.Models;
using GWSendMT.Supports;
using log4net;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GWSendMT.DataAccess
{
    public class DapperHelper
    {
        private readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Stopwatch watch = new Stopwatch();

        /// <summary>
        /// get senderid by account and sender name
        /// </summary>
        /// <param name="storedName"></param>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public IDictionary<string, object> AccountLoginAPI(string storedName, object[] keyValues)
        {
            if (logger.IsDebugEnabled)
            {
                watch.Restart();
                watch.Start();
            }

            IDictionary<string, object> resultReturn = new Dictionary<string, object>();
            string v_ErrCode = String.Empty;
            string v_ErrMessage = String.Empty;
            object result = new object();

            var dynamicParam = new OracleDynamicParameter();
            dynamicParam.Add("p_refcursor", OracleDbType.RefCursor, ParameterDirection.Output, null);
            dynamicParam.Add("p_account_id", OracleDbType.Long, ParameterDirection.Input, keyValues[0]);
            dynamicParam.Add("p_login_ip", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[1]);
            dynamicParam.Add("p_err_code", OracleDbType.Varchar2, ParameterDirection.Output, null, 100);
            dynamicParam.Add("p_err_message", OracleDbType.Varchar2, ParameterDirection.Output, null, 100);

            try
            {
                using (IDbConnection dbConnection = new OracleConnection(AppConfig.ORACLE_CONNECTION))
                {
                    dbConnection.Open();

                    result = SqlMapper.Query(dbConnection, storedName, param: dynamicParam, commandType: CommandType.StoredProcedure);

                    foreach (var parameter in dynamicParam.oracleParameters)
                    {
                        if (parameter.Direction == ParameterDirection.Output || parameter.Direction == ParameterDirection.InputOutput)
                        {
                            switch (parameter.ParameterName)
                            {
                                case "p_err_code":
                                    if (parameter.Value != DBNull.Value)
                                        v_ErrCode = (parameter.Value.ToString() == null) ? "1" : parameter.Value.ToString();
                                    break;
                                case "p_err_message":
                                    v_ErrMessage = parameter.Value.ToString();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    resultReturn.Add("err_code", v_ErrCode);
                    resultReturn.Add("err_message", v_ErrMessage);
                    resultReturn.Add("data", result);
                }
            }
            catch (Exception ex)
            {
                resultReturn.Add("err_code", "1");
                resultReturn.Add("err_message", ex);
                resultReturn.Add("data", result);
            }

            if (logger.IsDebugEnabled)
            {
                watch.Stop();
            }

            return resultReturn;
        }

        /// <summary>
        /// Insert SMS to database
        /// </summary>
        /// <param name="storedName"></param>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public async Task<ReturnModel> InsertSmsAsync(string storedName, object[] keyValues)
        {
            if (logger.IsDebugEnabled)
            {
                watch.Restart();
                watch.Start();
            }

            ReturnModel returnModel = new ReturnModel();

            try
            {
                OracleDynamicParameter parameters = new OracleDynamicParameter();
                parameters.Add("p_refcursor", OracleDbType.RefCursor, ParameterDirection.Output, null);
                parameters.Add("p_account_id", OracleDbType.Long, ParameterDirection.Input, keyValues[0]);
                parameters.Add("p_sender_id", OracleDbType.Long, ParameterDirection.Input, keyValues[1]);
                parameters.Add("p_sms_type", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[2]);
                parameters.Add("p_sms_content", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[3]);
                parameters.Add("p_sms_count", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[4]);
                parameters.Add("p_phone", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[5]);
                parameters.Add("p_telco", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[6]);
                parameters.Add("p_schedule_time", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[7]);
                parameters.Add("p_order_name", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[8]);
                parameters.Add("p_campaign_id", OracleDbType.Long, ParameterDirection.Input, keyValues[9]);
                parameters.Add("p_is_schedule", OracleDbType.Long, ParameterDirection.Input, keyValues[10]);
                parameters.Add("p_client_sms_id", OracleDbType.Long, ParameterDirection.Input, keyValues[11]);
                parameters.Add("p_via", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[12]);
                parameters.Add("p_is_encrypted", OracleDbType.Int16, ParameterDirection.Input, keyValues[13]);
                parameters.Add("p_err_code", OracleDbType.Varchar2, ParameterDirection.Output, null, 10);
                parameters.Add("p_err_message", OracleDbType.Varchar2, ParameterDirection.Output, null, 255);

                using (IDbConnection dbConnection = new OracleConnection(AppConfig.ORACLE_CONNECTION))
                {
                    await dbConnection.ExecuteAsync(storedName, param: parameters, commandType: CommandType.StoredProcedure);
                    returnModel.code = parameters.oracleParameters[parameters.oracleParameters.Count - 2]?.Value.ToString();
                    returnModel.message = parameters.oracleParameters[parameters.oracleParameters.Count - 1]?.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                returnModel.code = AppConst.SYS_ERR_EXCEPTION.ToString();
                returnModel.message = ex.ToString();
                logger.Error(Utils.A("InsertSMSAsync", storedName, ex));
            }

            if (logger.IsDebugEnabled)
            {
                watch.Stop();
                logger.Info(Utils.A("InsertSMSAsync.:Stopwatch", storedName, watch.ElapsedMilliseconds));
            }

            return returnModel;
        }

        /// <summary>
        /// get quota by account
        /// </summary>
        /// <param name="storedName"></param>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public IDictionary<string, object> GetQuotaByAccount(string storedName, object[] keyValues)
        {
            if (logger.IsDebugEnabled)
            {
                watch.Restart();
                watch.Start();
            }

            IDictionary<string, object> resultReturn = new Dictionary<string, object>();
            string v_ErrCode = String.Empty;
            string v_ErrMessage = String.Empty;
            object result = new object();

            var dynamicParam = new OracleDynamicParameter();
            dynamicParam.Add("p_refcursor", OracleDbType.RefCursor, ParameterDirection.Output, null);
            dynamicParam.Add("p_accountid", OracleDbType.Int32, ParameterDirection.Input, keyValues[0]);
            dynamicParam.Add("p_servicename", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[1]);
            dynamicParam.Add("p_err_code", OracleDbType.Varchar2, ParameterDirection.Output, null, 100);
            dynamicParam.Add("p_err_message", OracleDbType.Varchar2, ParameterDirection.Output, null, 100);

            try
            {
                using (IDbConnection dbConnection = new OracleConnection(AppConfig.ORACLE_CONNECTION))
                {
                    dbConnection.Open();

                    result = SqlMapper.Query(dbConnection, storedName, param: dynamicParam, commandType: CommandType.StoredProcedure);

                    foreach (var parameter in dynamicParam.oracleParameters)
                    {
                        if (parameter.Direction == ParameterDirection.Output || parameter.Direction == ParameterDirection.InputOutput)
                        {
                            switch (parameter.ParameterName)
                            {
                                case "p_err_code":
                                    if (parameter.Value != DBNull.Value)
                                        v_ErrCode = (parameter.Value.ToString() == null) ? "1" : parameter.Value.ToString();
                                    break;
                                case "p_err_message":
                                    v_ErrMessage = parameter.Value.ToString();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    resultReturn.Add("err_code", v_ErrCode);
                    resultReturn.Add("err_message", v_ErrMessage);
                    resultReturn.Add("data", result);
                }
            }
            catch (Exception ex)
            {
                resultReturn.Add("err_code", "1");
                resultReturn.Add("err_message", ex);
                resultReturn.Add("data", result);
            }

            if (logger.IsDebugEnabled)
            {
                watch.Stop();
            }

            return resultReturn;
        }

        /// <summary>
        /// get senderid by account and sender name
        /// </summary>
        /// <param name="storedName"></param>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public IDictionary<string, object> GetAccountSender(string storedName, object[] keyValues)
        {
            if (logger.IsDebugEnabled)
            {
                watch.Restart();
                watch.Start();
            }

            IDictionary<string, object> resultReturn = new Dictionary<string, object>();
            string v_ErrCode = String.Empty;
            string v_ErrMessage = String.Empty;
            object result = new object();

            var dynamicParam = new OracleDynamicParameter();
            dynamicParam.Add("p_refcursor", OracleDbType.RefCursor, ParameterDirection.Output, null);
            dynamicParam.Add("p_account_id", OracleDbType.Long, ParameterDirection.Input, keyValues[0]);
            dynamicParam.Add("p_sender_name", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[1]);
            dynamicParam.Add("p_sms_type", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[2]);
            dynamicParam.Add("p_err_code", OracleDbType.Varchar2, ParameterDirection.Output, null, 100);
            dynamicParam.Add("p_err_message", OracleDbType.Varchar2, ParameterDirection.Output, null, 100);

            try
            {
                using (IDbConnection dbConnection = new OracleConnection(AppConfig.ORACLE_CONNECTION))
                {
                    dbConnection.Open();

                    result = SqlMapper.Query(dbConnection, storedName, param: dynamicParam, commandType: CommandType.StoredProcedure);

                    foreach (var parameter in dynamicParam.oracleParameters)
                    {
                        if (parameter.Direction == ParameterDirection.Output || parameter.Direction == ParameterDirection.InputOutput)
                        {
                            switch (parameter.ParameterName)
                            {
                                case "p_err_code":
                                    if (parameter.Value != DBNull.Value)
                                        v_ErrCode = (parameter.Value.ToString() == null) ? "1" : parameter.Value.ToString();
                                    break;
                                case "p_err_message":
                                    v_ErrMessage = parameter.Value.ToString();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    resultReturn.Add("err_code", v_ErrCode);
                    resultReturn.Add("err_message", v_ErrMessage);
                    resultReturn.Add("data", result);
                }
            }
            catch (Exception ex)
            {
                resultReturn.Add("err_code", "1");
                resultReturn.Add("err_message", ex);
                resultReturn.Add("data", result);
            }

            if (logger.IsDebugEnabled)
            {
                watch.Stop();
            }

            return resultReturn;
        }

        /// <summary>
        /// get senderid by account and sender name
        /// </summary>
        /// <param name="storedName"></param>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public IDictionary<string, object> GetMappingByTelco(string storedName, object[] keyValues)
        {
            if (logger.IsDebugEnabled)
            {
                watch.Restart();
                watch.Start();
            }

            IDictionary<string, object> resultReturn = new Dictionary<string, object>();
            string v_ErrCode = String.Empty;
            string v_ErrMessage = String.Empty;
            object result = new object();

            var dynamicParam = new OracleDynamicParameter();
            dynamicParam.Add("p_refcursor", OracleDbType.RefCursor, ParameterDirection.Output, null);
            dynamicParam.Add("p_account_id", OracleDbType.Long, ParameterDirection.Input, keyValues[0]);
            dynamicParam.Add("p_sender_id", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[1]);
            dynamicParam.Add("p_telco", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[2]);
            dynamicParam.Add("p_sms_type", OracleDbType.Varchar2, ParameterDirection.Input, keyValues[3]);
            dynamicParam.Add("p_err_code", OracleDbType.Varchar2, ParameterDirection.Output, null, 100);
            dynamicParam.Add("p_err_message", OracleDbType.Varchar2, ParameterDirection.Output, null, 100);

            try
            {
                using (IDbConnection dbConnection = new OracleConnection(AppConfig.ORACLE_CONNECTION))
                {
                    dbConnection.Open();

                    result = SqlMapper.Query(dbConnection, storedName, param: dynamicParam, commandType: CommandType.StoredProcedure);

                    foreach (var parameter in dynamicParam.oracleParameters)
                    {
                        if (parameter.Direction == ParameterDirection.Output || parameter.Direction == ParameterDirection.InputOutput)
                        {
                            switch (parameter.ParameterName)
                            {
                                case "p_err_code":
                                    if (parameter.Value != DBNull.Value)
                                        v_ErrCode = (parameter.Value.ToString() == null) ? "1" : parameter.Value.ToString();
                                    break;
                                case "p_err_message":
                                    v_ErrMessage = parameter.Value.ToString();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    resultReturn.Add("err_code", v_ErrCode);
                    resultReturn.Add("err_message", v_ErrMessage);
                    resultReturn.Add("data", result);
                }
            }
            catch (Exception ex)
            {
                resultReturn.Add("err_code", "1");
                resultReturn.Add("err_message", ex);
                resultReturn.Add("data", result);
            }

            if (logger.IsDebugEnabled)
            {
                watch.Stop();
            }

            return resultReturn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="storedName"></param>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public async Task<ReturnModel> UpdateQuota(string storedName, long account_id, string type, long count)
        {
            if (logger.IsDebugEnabled)
            {
                watch.Restart();
                watch.Start();
            }

            ReturnModel returnModel = new ReturnModel();

            try
            {
                OracleDynamicParameter parameters = new OracleDynamicParameter();
                parameters.Add("p_refcursor", OracleDbType.RefCursor, ParameterDirection.Output, null);
                parameters.Add("p_accountid", OracleDbType.Long, ParameterDirection.Input, account_id);
                parameters.Add("p_servicename", OracleDbType.Varchar2, ParameterDirection.Input, type);
                parameters.Add("p_quota_use", OracleDbType.Long, ParameterDirection.Input, count);
                parameters.Add("p_err_code", OracleDbType.Varchar2, ParameterDirection.Output, null, 10);
                parameters.Add("p_err_message", OracleDbType.Varchar2, ParameterDirection.Output, null, 255);

                using (IDbConnection dbConnection = new OracleConnection(AppConfig.ORACLE_CONNECTION))
                {
                    await dbConnection.ExecuteAsync(storedName, param: parameters, commandType: CommandType.StoredProcedure);
                    returnModel.code = parameters.oracleParameters[parameters.oracleParameters.Count - 2]?.Value.ToString();
                    returnModel.message = parameters.oracleParameters[parameters.oracleParameters.Count - 1]?.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                returnModel.code = AppConst.SYS_ERR_EXCEPTION.ToString();
                returnModel.message = ex.ToString();
                logger.Error(Utils.A("UpdateQuota", storedName, ex));
            }

            if (logger.IsDebugEnabled)
            {
                watch.Stop();
                logger.Info(Utils.A("UpdateQuota.:Stopwatch", storedName, watch.ElapsedMilliseconds));
            }

            return returnModel;
        }
    }
}
