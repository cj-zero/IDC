using IDC.Application.Common.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali.Request
{
    public class QueryassetListReq : PageReq
    {
        /// <summary>
        /// 资产ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public string AssetCategory { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public string OrgName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string AssetStatus { get; set; }
        /// <summary>
        /// 送检类型
        /// </summary>
        public string AssetInspectType { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        public string AssetType { get; set; }
        /// <summary>
        /// 出厂编号S/N
        /// </summary>
        public string AssetStockNumber { get; set; }
        /// <summary>
        /// 资产编号
        /// </summary>
        public string AssetNumber { get; set; }
        /// <summary>
        /// 校准日期
        /// </summary>
        public System.DateTime? AssetStartDate { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        public System.DateTime? AssetEndDate { get; set; }
        //todo:添加自己的请求字段

        public string CustomerId { get; set; }
        /// <summary>
        /// 是否排除已组合资产
        /// </summary>
        public bool isMap { get; set; } = false;
    }
}
