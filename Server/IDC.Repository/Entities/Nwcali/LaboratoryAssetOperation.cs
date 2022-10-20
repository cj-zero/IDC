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
	/// 资产操作表
	/// </summary>
    [Table("LaboratoryAssetOperation")]
    public partial class LaboratoryAssetOperation : Entity
    {
        public LaboratoryAssetOperation()
        {
            this.InspectId = string.Empty;
            this.OperationContent = string.Empty;
            this.OperationCreateTime = DateTime.Now;
            this.OperationUser = string.Empty;
        }


        /// <summary>
        /// 资产ID
        /// </summary>
        [Description("资产ID")]
        public int LaboratoryAssetId { get; set; }
        /// <summary>
        /// 送检ID
        /// </summary>
        [Description("送检ID")]
        public string InspectId { get; set; }
        /// <summary>
        /// 操作内容
        /// </summary>
        [Description("操作内容")]
        public string OperationContent { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        [Description("操作时间")]
        public System.DateTime? OperationCreateTime { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        [Description("操作人")]
        public string OperationUser { get; set; }
    }
}
