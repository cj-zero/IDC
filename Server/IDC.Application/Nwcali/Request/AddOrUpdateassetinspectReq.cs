using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali.Request
{
    /// <summary>
    /// 送检表
    /// </summary>
    public partial class AddOrUpdateassetinspectReq
    {

        /// <summary>
        /// 送检ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 资产ID
        /// </summary>
        public int? AssetId { get; set; }
        /// <summary>
        /// 校准日期
        /// </summary>
        public System.DateTime? InspectStartDate { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        public System.DateTime? InspectEndDate { get; set; }
        /// <summary>
        /// 校准证书
        /// </summary>
        public string InspectCertificate { get; set; }
        /// <summary>
        /// 校准数据1
        /// </summary>
        public string InspectDataOne { get; set; }
        /// <summary>
        /// 校准数据2
        /// </summary>
        public string InspectDataTwo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public System.DateTime? InspectCreatTime { get; set; }

        //todo:添加自己的请求字段
    }
}
