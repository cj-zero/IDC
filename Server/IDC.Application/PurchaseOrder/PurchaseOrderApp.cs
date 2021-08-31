using Dapper;
using IDC.Application.Basics;
using IDC.Application.PurchaseOrder.Response;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.NsapBone;
using IDC.Repository.Entities.Sap;
using System;
using System.Collections.Generic;
using System.Linq;
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

                var pdnDocEntryList = pdnList.Select(c => c.pdn).Distinct().ToList();
                Dictionary<int, List<object>> dic = new Dictionary<int, List<object>>();
                foreach (var item in pdnDocEntryList)
                {
                    int items = Convert.ToInt32(item);
                    var list = pdnList.Where(c => c.pdn == item).ToList();
                    dic.Add(items, list);
                }
                result.Data = dic;
            }
            catch (Exception e)
            {
                result.Code = 500;
                result.Message = ""+ docentry + " 根据采购单获取收货单查询失败！ex:" + e.Message;
            }
            return result;
        }
    }
}
