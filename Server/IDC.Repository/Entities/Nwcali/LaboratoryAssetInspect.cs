using IDC.Repository.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Nwcali
{
    /// <summary>
    /// 资产送检表
    /// </summary>
    [Table("LaboratoryAssetInspect")]
    public partial class LaboratoryAssetInspect : Entity
    {
        public LaboratoryAssetInspect()
        {
            this.InspectStartDate = DateTime.Now;
            this.InspectEndDate = DateTime.Now;
            this.InspectCertificate = string.Empty;
            this.InspectDataOne = string.Empty;
            this.InspectDataTwo = string.Empty;
            this.InspectCreatTime = DateTime.Now;
        }


        /// <summary>
        /// 资产ID
        /// </summary>
        [Description("资产ID")]
        public int LaboratoryAssetId { get; set; }
        /// <summary>
        /// 校准日期
        /// </summary>
        [Description("校准日期")]
        public System.DateTime? InspectStartDate { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        [Description("失效日期")]
        public System.DateTime? InspectEndDate { get; set; }
        /// <summary>
        /// 校准证书
        /// </summary>
        [Description("校准证书")]
        public string InspectCertificate { get; set; }
        /// <summary>
        /// 校准数据1
        /// </summary>
        [Description("校准数据1")]
        public string InspectDataOne { get; set; }
        /// <summary>
        /// 校准数据2
        /// </summary>
        [Description("校准数据2")]
        public string InspectDataTwo { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        [Description("操作时间")]
        public System.DateTime? InspectCreatTime { get; set; }
    }
}
