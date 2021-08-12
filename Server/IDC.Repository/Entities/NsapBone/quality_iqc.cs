using Dapper.Contrib.Extensions;
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
    [ConnectionString("NsapBoneDbContext", "NsapBoneReadDbContext")]
    public partial class quality_iqc 
    {
        public quality_iqc()
        {
          this.ItemCode= string.Empty;
          this.ItemName= string.Empty;
          this.CardCode= string.Empty;
          this.CardName= string.Empty;
          this.Income_dt= DateTime.Now;
          this.Inspect_dimension= string.Empty;
          this.Inspect_function= string.Empty;
          this.Inspect_appearance= string.Empty;
          this.Inspect_other= string.Empty;
          this.Inspect_result= string.Empty;
          this.Defective_desc= string.Empty;
          this.Check_remark= string.Empty;
          this.Item_pic= string.Empty;
          this.ProcessOperation= string.Empty;
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Key]
        public int seq_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Pur_no { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? Income_dt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Inspect_dimension { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Inspect_function { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Inspect_appearance { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Inspect_other { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Income_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Sample_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Defective_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Inspect_result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Defective_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Check_remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Item_pic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ProcessOperation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Accept_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Reject_num { get; set; }
    }
}