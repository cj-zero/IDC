using Dapper;
using IDC.Application.Basics;
using IDC.Application.PurchaseOrder.Response;
using IDC.Application.SapHandler.Request;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.NsapBase;
using IDC.Repository.Entities.NsapBone;
using IDC.Repository.Entities.Sap;
using NSAP.Entity.Sales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.PurchaseOrder
{
    /// <summary>
    /// 采购订单
    /// </summary>
    public class PurchaseOrderApp : BaseApp
    {
        public PurchaseOrderApp(IRepositoryBase repositoryBase, IAuth auth) : base(auth, repositoryBase)
        {
        }

        /// <summary>
        /// 根据采购单号获取采购单信息
        /// </summary>
        /// <param name="docentry"></param>
        /// <returns></returns>
        public async Task<TableData> GetPurchaseOrderList(string docentry)
        {
            try
            {
                var result = new TableData();
                StringBuilder sql = new StringBuilder();
                sql.AppendFormat(@"select a.DocEntry,b.ItemCode,b.Dscription,b.Quantity,b.linetotal,a.createDate,d.WhsName,d.WhsCode,f.SlpName,b.price 
                                from buy_opor a
                                left join buy_por1 b on a.DocEntry=b.DocEntry and a.sbo_id=b.sbo_id
                                left join store_owhs d on b.WhsCode=d.WhsCode
                                LEFT JOIN crm_oslp f ON a.SlpCode = f.SlpCode 
                                where a.DocEntry=@DocEntry");
                var Parameters = new DynamicParameters();
                Parameters.Add("DocEntry", docentry);
                var oporList = (await _repositoryBase.FindAsync<buy_opor>(sql.ToString(), Parameters)).ToList();
                result.Data = oporList.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("单号" + docentry + ""+ex.Message);
            }
        }

        /// <summary>
        /// 根据采购单获取收货单
        /// </summary>
        /// <param name="docentry"></param>
        /// <returns></returns>
        public async Task<TableData> GetOpdnByOpor(string docentry)
        {
            var result = new TableData();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendFormat(@"select a.sbo_id,a.DocEntry,b.DocEntry as pdn,b.ItemCode,b.Dscription,b.Quantity,b.linetotal,c.createDate,d.WhsName,d.WhsCode,f.SlpName,b.price  
                                from buy_opor a
                                inner join buy_pdn1 b on a.DocEntry=b.BaseEntry and a.sbo_id=b.sbo_id
                                left join buy_opdn c on c.DocEntry=b.DocEntry
                                left join store_owhs d on b.WhsCode=d.WhsCode
                                LEFT JOIN crm_oslp f ON a.SlpCode = f.SlpCode 
                                where b.BaseType=22 and a.DocEntry=@DocEntry");
                var Parameters = new DynamicParameters();
                Parameters.Add("DocEntry", docentry);
                var pdnList = (await _repositoryBase.FindAsync<buy_pdn1>(sql.ToString(), Parameters)).OrderByDescending(c => c.DocEntry).ToList();
                result.Data = pdnList;
            }
            catch (Exception e)
            {
                result.Code = 500;
                result.Message = ""+ docentry + " 根据采购单获取收货单查询失败！ex:" + e.Message;
            }
            return result;
        }

        /// <summary>
        /// 根据passport_id 获取ERP3.0 user_id
        /// </summary>
        /// <param name="passport_id"></param>
        /// <returns></returns>
        public async Task<TableData> GetUserInfoByPassportId(int passport_id)
        {
            var result = new TableData();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendFormat(@"select b.user_id from base_user_app_map a join base_user b on a.user_id=b.user_id where a.passport_id=@passport_id");
                var Parameters = new DynamicParameters();
                Parameters.Add("passport_id", passport_id);
                var baseUserInfo = (await _repositoryBase.FindAsync<base_user>(sql.ToString(), Parameters)).FirstOrDefault();
                result.Data = baseUserInfo;
            }
            catch (Exception e)
            {
                result.Code = 500;
                result.Message = e.Message;
            }
            return result;
        }

        #region 获取仓库列表
        /// <summary>
        /// 获取仓库列表
        /// </summary>
        /// <param name="key">关键词</param>
        /// <returns></returns>
        public async Task<TableData> GetStoreOwhsList(string key = "")
        {
            var result = new TableData();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendFormat(@"select WhsCode,WhsName,dep_id,user_id,Locked from store_owhs where 1=1 and sbo_id={0} ", Define.Sbo_Id);
                if (!string.IsNullOrWhiteSpace(key))
                {
                    sql.AppendFormat(@" and (WhsCode like '%{0}%' or WhsName like '%{0}%')", key);
                }
                var storeOwhsList = (await _repositoryBase.FindAsync<store_osrn>(sql.ToString(), null)).OrderBy(c => c.WhsCode).ToList();
                result.Data = storeOwhsList;
            }
            catch (Exception e)
            {
                result.Code = 500;
                result.Message =e.Message;
            }
            return result;
        }
        #endregion

        #region 库存转储
        /// <summary>
        /// 创建并提交库存转储
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<TableData> StockTransferSave(StockTransferReq req)
        {
            var results = new TableData();
            try
            {
                string result = "0"; int FuncID = 0;
                byte[] job_data = Serialize(req.storeOWTR);
                if (req.storeOWTR.WhsCode == "37" && req.storeOWTR.Filler != "01") //37仓走单独的流程
                {
                    FuncID = int.Parse(await GetFuncIdByURL("store/StockTransfer_Main.aspx"));
                }
                else
                {
                    FuncID = int.Parse(await GetFuncIdByURL("store/StockTransfer.aspx"));
                }
                result = await WorkflowBuild("库存转储", FuncID, req.UserID, job_data, req.storeOWTR.Comments, Define.Sbo_Id, req.storeOWTR.CardCode, req.storeOWTR.CardName, 0, -1, 0, "BOneAPI", "NSAP.B1Api.BOneOWTR");
                if (int.Parse(result) > 0)
                {
                    int newjobid = int.Parse(result);
                    int user_id = 0;
                    //转入仓库保存，用于不良品仓审批流跳转
                    await AddStockJump(result, req._WhsCode);
                    //保存最终审批仓库，用于到仓库主管审批时取仓库主管
                    await UpdateWfaJobPara(result, 2, req.AuditWhs);
                    //int.Parse(result), req.UserID, req.storeOWTR.Comments, "", 0
                    await WorkflowSubmit(new ApprovalReq { jobID = int.Parse(result), UserID = req.UserID, remarks = req.storeOWTR.Comments, cont = "", auditor = 0 });
                    #region 如果到了仓库主管审核步骤，则设置工作流审批人为仓库主管
                    var steptab = await GetAuditStepName(newjobid);
                    if (steptab != null && steptab.Count > 0)
                    {
                        string stepnm = steptab.FirstOrDefault().step_nm.ToString();
                        if (stepnm == "仓库主管审核")
                        {
                            user_id = Convert.ToInt32(await SelectWhsUser(req.AuditWhs, Define.Sbo_Id.ToString()));
                            if (user_id > 0)
                            {
                                await UpdateAuditPsn(newjobid, int.Parse(steptab.FirstOrDefault().audit_level.ToString()), user_id);
                            }
                        }
                    }
                    #endregion
                    if (req.storeOWTR.serialNumber.Count > 0)
                    {
                        await UpdateSerialNumber(req.storeOWTR.serialNumber, newjobid);
                    }
                }
                results.Data = result;
            }
            catch (Exception ex)
            {
                results.Code = 500;
                results.Message = ex.Message;
            }
            return results;
        }
        /// <summary>
        /// 审批库存转储单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<string> Approval(ApprovalReq req)
        {
            return await WorkflowSubmit(req);
        }

        #endregion

        #region 通用获取数据
        /// <summary>
        /// 获取页面的FuncID
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        public async Task<string> GetFuncIdByURL(string PageURL)
        {
            string sql = string.Format("SELECT T1.func_id FROM base_page AS T0 LEFT JOIN base_func AS T1 ON T0.page_id = T1.page_id WHERE T0.page_url = @page_url");
            var obj = await _repositoryBase.DetailAsync<base_dep>(sql, new { page_url = PageURL });
            return obj == null ? "0" : obj.func_id.ToString();
        }
        #region 05仓不良品条状
        /// <summary>
        /// 05仓不良品条状
        /// </summary>
        /// <returns></returns>
        public async Task<string> AddStockJump(string JobID, string para_val)
        {
            string sql = string.Format("insert into wfa_job_para (job_id,para_idx,para_val) VALUES('{0}','{1}','{2}') ON DUPLICATE KEY UPDATE para_val='{2}'  ", JobID, 1, para_val);
            //return Sql.Action.ExecuteNonQuery(Sql.GB2312ConnectionString, CommandType.Text, sql) > 0 ? "1" : "-1";
            var obj = await _repositoryBase.BatchAddAsync<base_dep>(sql);
            return obj > 0 ? "1" : "-1";
        }
        #endregion

        #region 修改流程任务参数值
        /// <summary>
        /// 修改流程任务参数值
        /// </summary>
        public async Task<bool> UpdateWfaJobPara(string jobId, int para_idx, string para_val)
        {
            var sql = string.Format("INSERT INTO wfa_job_para(job_id,para_idx,para_val) VALUES('{0}','{1}','{2}') ON DUPLICATE KEY UPDATE para_val= '{2}'", jobId, para_idx, para_val);
            int rows = await _repositoryBase.BatchAddAsync<base_dep>(sql);
            return rows > 0 ? true : false;
        }
        #endregion

        /// <summary>
        /// 获取工作流当前步骤名称
        /// </summary>
        /// <param name="JobId"></param>
        /// <returns></returns>
        public async Task<List<dynamic>> GetAuditStepName(int JobId)
        {
            string strSql = string.Format("SELECT a.step_id,b.step_nm,b.audit_level FROM wfa_job a LEFT JOIN wfa_step b ON a.step_id=b.step_id WHERE a.job_id={0}", JobId);
            return (await _repositoryBase.FindAsync<base_user>(strSql)).ToList();
        }
        public async Task<string> UpdateAuditPsn(int job_id, int audit_level, int audit_obj)
        {
            string strsql = string.Format(@"delete from wfa_jump where user_id={0} and job_id={1} and audit_level={2};
                                            update wfa_jump set user_id={0} where state=0 and user_id=0 and job_id={1} and audit_level={2}", audit_obj, job_id, audit_level);
            return await _repositoryBase.BatchAddAsync<base_dep>(strsql) > 0 ? "1" : "-1";
        }
        /// <summary>
        /// 查询仓库审核人
        /// </summary>
        public async Task<string> SelectWhsUser(string wohs, string sboID)
        {
            string PrintSql = string.Format("SELECT user_id FROM store_owhs WHERE WhsCode = '{0}' and sbo_id ={1};", wohs, sboID);
            var _t = await _repositoryBase.DetailAsync<buy_opor>(PrintSql);
            return _t == null ? "-1" : _t.user_id.ToString();
        }
        //修改已选择序列号状态
        public async Task<bool> UpdateSerialNumber(IList<billSerialNumber> osrnlist, int submitjobid)
        {
            string strSql = string.Empty;
            int res = 0;
            foreach (billSerialNumber osrn in osrnlist)
            {
                foreach (billSerialNumberChooseItem serial in osrn.Details)
                {
                    strSql = string.Format("INSERT INTO store_osrn_alreadyexists (ItemCode,SysNumber,DistNumber,MnfSerial,IsChange,JobId) VALUES (@ItemCode,@SysNumber,@DistNumber,@MnfSerial,@IsChange,@JobId) ON Duplicate KEY UPDATE DistNumber=VALUES(DistNumber),MnfSerial=VALUES(MnfSerial),IsChange=VALUES(IsChange),JobId=VALUES(JobId)");
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@ItemCode", osrn.ItemCode);
                    parameters.Add("@SysNumber", int.Parse(serial.SysSerial));
                    parameters.Add("@DistNumber", serial.IntrSerial);
                    parameters.Add("@MnfSerial", serial.SuppSerial);
                    parameters.Add("@IsChange", 1);
                    parameters.Add("@JobId", submitjobid);
                    res = await _repositoryBase.BatchAddAsync<buy_opor>(strSql, parameters);
                }
            }
            return res > 0 ? true : false;
        }
        public static byte[] Serialize(dynamic oClass)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, oClass);
                return stream.ToArray();
            }
        }

        #endregion

        #region 审批流
        #region 存草稿
        /// <summary>
        /// 库存转储（存草稿）
        /// </summary>
        /// <returns></returns>
        public async Task<string> WorkflowBuild(string jobName, int funcID, int userID, byte[] jobdata, string remarks, int sboID, string carCode,
            string carName, double docTotal, int baseType, int baseEntry, string assemblyName, string className)
        {
            //if (carCode != "")
            //{
            //    string carNameis = "";
            //    int rowCounts;
            //    StringBuilder tableName = new StringBuilder();
            //    StringBuilder filedName = new StringBuilder();
            //    filedName.Append(" A.CardName ");
            //    tableName.Append("  nsap_bone.crm_ocrd A ");
            //    DataTable dt = Sql.SelectPagingHaveRowsCount(tableName.ToString(), filedName.ToString(), 1, 1, "", " A.sbo_id=" + sboID + " and A.CardCode='" + carCode + "'", out rowCounts);
            //    if (dt.Rows.Count > 0)
            //    {
            //        carName = dt.Rows[0][0].ToString();
            //    }
            //}MySqlDbType.MediumBlob
            //var test = new { pJobName = jobName, pFuncID = funcID, pJobData = jobdata , pUserID = userID, pRemarks = remarks, pSboID= sboID, pCarCode = carCode, pCarName = carName, pDocTotal = docTotal , pBaseEntry = baseEntry ,pBaseType= baseType, pAssemblyName = assemblyName , pClassName = className };
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("?pJobName", jobName);
            parameters.Add("?pFuncID", funcID);
            parameters.Add("?pJobData", jobdata);
            parameters.Add("?pUserID", userID);
            parameters.Add("?pRemarks", remarks);
            parameters.Add("?pSboID", sboID);
            parameters.Add("?pCarCode", carCode);
            parameters.Add("?pCarName", carName);
            parameters.Add("?pDocTotal", docTotal);
            parameters.Add("?pBaseType", baseType);
            parameters.Add("?pBaseEntry", baseEntry);
            parameters.Add("?pAssemblyName", assemblyName);
            parameters.Add("?pClassName", className);

            return (await _repositoryBase.ProcAsync<base_dep>("sp_process_build", parameters)).ToString();
        }
        #endregion
        #region 提交审核
        /// <summary>
        ///  库存转储（提交）
        /// </summary>
        /// <returns>返回  提交失败 0   提交成功 1   流程完成 2</returns>
        public async Task<string> WorkflowSubmit(ApprovalReq req)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("?pJobID", req.jobID);
            parameters.Add("?pUserID", req.UserID);
            parameters.Add("?pRemarks", req.remarks);
            parameters.Add("?pCont", req.cont);
            parameters.Add("?pAuditor", req.auditor);
            return (await _repositoryBase.ProcAsync<base_dep>("sp_process_submit", parameters)).ToString();
        }
        #endregion
        #endregion


        public async Task<TableData> GetStockTransferResult(string list)
        {
            var result = new TableData();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendFormat(@"select job_id,job_state from wfa_job where job_id in ({0})", list);
                var res = (await _repositoryBase.FindAsync<base_user>(sql.ToString(), null)).ToList();
                result.Data = res;
            }
            catch (Exception e)
            {
                result.Code = 500;
                result.Message = e.Message;
            }
            return result;
        }
    }
}
