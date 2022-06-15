using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.WMS.Request
{
    public class StockTransferDetail
    {
        /// <summary>
        /// 物料号
        /// </summary>
        public string ItemCode { get; set; }
        /// <summary>
        /// 物料/服务描述
        /// </summary>
        
        public string Dscription { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        
        public string Quantity { get; set; }

        /// <summary>
        /// 到仓库代码
        /// </summary>
        
        public string WhsCode { get; set; }

        
        public IList<BillSerialNumberChooseItem> ChoosedSerialNumberList { get; set; }

    }
}
