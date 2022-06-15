using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.WMS.Request
{
    public class AddOrUpdStockTransferReq
    {
        /// <summary>
        /// 收货地址
        /// </summary>
        
        public string Address { get; set; }
        /// <summary>
        /// 业务伙伴代码
        /// </summary>
        
        public string CardCode { get; set; }
        /// <summary>
        /// 业务伙伴名称
        /// </summary>
        
        public string CardName { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        
        public string CntctCode { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        
        public string Comments { get; set; }
      
        /// <summary>
        /// 过账日期
        /// </summary>
        
        public string DocDate { get; set; }
        /// <summary>
        /// 从仓库
        /// </summary>
        
        public string Filler { get; set; }
       
        /// <summary>
        /// 当前帐套
        /// </summary>
        
        public string SboId { get; set; }
        /// <summary>
        /// 销售员
        /// </summary>
        
        public string SlpCode { get; set; }
        /// <summary>
        /// 单据日期
        /// </summary>
        
        public string TaxDate { get; set; }
        /// <summary>
        /// 到仓库
        /// </summary>
        
        public string WhsCode { get; set; }

        /// <summary>
        /// 设备箱号
        /// </summary>
        public string U_CPH { get; set; }
        /// <summary>
        /// 验收期限
        /// </summary>

        public string U_YSQX { get; set; }

        /// <summary>
        /// 系统操作者
        /// </summary>

        public string U_YGMD { get; set; }
        /// <summary>
        /// 行明细
        /// </summary>

        public IList<StockTransferDetail> billStockDetails { get; set; }
       
    }
}
