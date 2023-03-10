using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBone
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBoneDbContext", "NsapBoneReadDbContext")]
    public partial class store_item_type 
    {
        public store_item_type()
        {
          this.type_alias= string.Empty;
          this.type_nm= string.Empty;
          this.type_coding_exp= string.Empty;
          this.type_desc_exp= string.Empty;
          this.upd_dt= DateTime.Now;
          this.job_id= 0;
          this.user_id= 0;
          this.machining_time= 0;
          this.machining_price= 0;
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Key]
        public int type_id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string type_alias { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string type_nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public uint parent_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool type_level { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public uint order_idx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string type_coding_exp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string type_desc_exp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool valid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime upd_dt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public sbyte code_rule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int job_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int user_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public sbyte is_aatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int machining_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal machining_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool is_bom_attach { get; set; }
    }
}