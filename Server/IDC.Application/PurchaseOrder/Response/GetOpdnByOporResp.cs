using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.PurchaseOrder.Response
{
    public class GetOpdnByOporResp
    {
        /// <summary>
        /// 账套Id
        /// </summary>
        public string sbo_id { get; set; }
        /// <summary>
        /// 采购单号
        /// </summary>
        public string DocEntry { get; set; }
        /// <summary>
        /// 收货单号
        /// </summary>
        public string pdn { get; set; }
        /// <summary>
        /// 物料编号
        /// </summary>
        public string ItemCode { get; set; }
        /// <summary>
        /// 物料描述
        /// </summary>
        public string Dscription { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal linetotal { get; set; }
        /// <summary>
        /// 收货日期
        /// </summary>
        public DateTime createDate { get; set; }
        /// <summary>
        /// 仓库名字
        /// </summary>
        public string WhsName { get; set; }
        /// <summary>
        /// 仓库代码
        /// </summary>
        public string WhsCode { get; set; }
        /// <summary>
        /// 采购员
        /// </summary>
        public string SlpName { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal price { get; set; }

    }
}
