using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBone
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBoneDbContext","NsapBoneReadDbContext")]
    public partial class store_itl1 
    {
        public store_itl1()
        {
        }


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int SysNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? AllocQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? MdAbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ReleaseQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? PickedQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? sbo_id { get; set; }
    }
}