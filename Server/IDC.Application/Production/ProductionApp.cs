using Dapper;
using IDC.Application.Basics;
using IDC.Application.Production.Request;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.NsapBone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Production
{
    public class ProductionApp : BaseApp
    {
        public ProductionApp(IRepositoryBase repositoryBase, IAuth auth) : base(auth, repositoryBase)
        {
        }

        /// <summary>
        /// 获取生产订单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TableData> GetProductionList(QueryProductionList request)
        {
            var result = new TableData();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT DocEntry,Type,CardCode,OriginAbs,ItemCode,CreateDate,PlannedQty,Uom,U_WO_LTDW,Warehouse,Status from product_owor where 1=1 ");
            var Parameters = new DynamicParameters();
            if (!string.IsNullOrWhiteSpace(request.StartDate))
            {
                sql.Append("and UpdateDate >= @StartDate");
                Parameters.Add("@StartDate",DateTime.Parse(request.StartDate).Date);
            }
            if (!string.IsNullOrWhiteSpace(request.EndDate))
            {
                sql.Append("and UpdateDate < @EndDate");
                Parameters.Add("@EndDate", DateTime.Parse(request.EndDate).AddDays(1).Date);
            }
            sql.Append(" limit @Start,@End");
            Parameters.Add("@Start", (request.page - 1) * request.limit);
            Parameters.Add("@End", request.limit);
            result.Count = (await _repositoryBase.GetAsync<product_owor>(sql.ToString(), Parameters)).Count();
            result.Data = (await _repositoryBase.GetAsync<product_owor>(sql.ToString(), Parameters)).Select(c => new
            {
                wo = c.DocEntry,//生产单号
                wo_header_id = c.DocEntry,
                wo_line_id = 1,
                wo_erp_no = 1,
                wot_erp_type = replace(c.Type, ""),//类型
                wot_erp_type_name = replace(c.Type, "name"),
                cust_no = c.CardCode,
                wot_erp_po = c.OriginAbs,//销售单号
                wot_erp_po_line = "",
                pt_no = c.ItemCode,//产品品号
                bom_no = "",
                wot_createdate = c.CreateDate,
                wot_shipping_date = "",
                wot_plan_begdate = "",
                wot_plan_enddate = "",
                wot_plan_qty = c.PlannedQty,
                pt_unit = c.Uom,
                wot_work_center = "",
                wot_dept = c.U_WO_LTDW,
                wot_receipt_wh = c.Warehouse,
                wot_status = c.Status,
                wot_source_type = "ERP"
            });
            return result;
        }

        public async Task<TableData> GetStoreOwtrList(QueryProductionList request)
        {
            var result = new TableData();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT a.* from product_store_relation a left JOIN store_wtr1 b on a.StoreId=b.DocEntry where 1=1 ");
            var Parameters = new DynamicParameters();
            if (!string.IsNullOrWhiteSpace(request.StartDate))
            {
                sql.Append("and b.UpdateDate >= @StartDate");
                Parameters.Add("@StartDate", DateTime.Parse(request.StartDate).Date);
            }
            if (!string.IsNullOrWhiteSpace(request.EndDate))
            {
                sql.Append("and b.UpdateDate < @EndDate");
                Parameters.Add("@EndDate", DateTime.Parse(request.EndDate).AddDays(1).Date);
            }
            sql.Append(" limit @Start,@End");
            Parameters.Add("@Start", (request.page - 1) * request.limit);
            Parameters.Add("@End", request.limit);
            var list = (await _repositoryBase.GetAsync<product_store_relation>(sql.ToString(), Parameters)).ToList();

            //detail
            var docentry = string.Join(',', list.Select(c => c.StoreId).ToList());
            string detailSql = "SELECT a.*,b.BuyUnitMsr from store_wtr1 a left join store_oitm b on a.itemCode=b.ItemCode where a.DocEntry in (" + docentry + ")";
            var detailList= (await _repositoryBase.GetAsync<store_wtr1>(detailSql)).ToList();

            result.Count = list.Count();
            result.Data = list.Select(c => new
            {
                wsst_source_header_id = c.ProductId,
                wo = c.ProductId,
                wsst_docno = c.StoreId,
                wsst_status = 0,
                delete_flag = 0,
                detail = detailList.Where(o => o.DocEntry == c.StoreId).Select(o => new
                {
                    wssd_source_line_id = c.StoreId.ToString()+o.LineNum.ToString(),
                    wo = c.ProductId,
                    pt_no = o.ItemCode,
                    wssd_plan_qty = o.Quantity,
                    wssd_usage = "",//单位用量
                    wssd_unit = o.BuyUnitMsr,//单位
                    wssd_bom_item = o.LineNum,
                    delete_flag = 0
                })
            });
            return result;
        }

        private string replace(string text,string type)
        {
            var value = string.Empty;
            if (type == "name")
            {
                switch (text)
                {
                    case "1":
                        value = "正常";
                        break;
                    case "3":
                        value = "返工";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (text)
                {
                    case "S":
                        value = "1";
                        break;
                    case "D":
                        value = "3";
                        break;
                    default:
                        break;
                }
            }
            return value;
        }
    }
}
