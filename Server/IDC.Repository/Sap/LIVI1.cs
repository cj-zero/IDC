using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using IDC.Repository.Dapper;

namespace IDC.Repository.Entities.Sap
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("SapDbContext", "SapReadDbContext", DatabaseType.SqlServer)]
    public partial class LIVI1 
    {
        public LIVI1()
        {
          this.CreateDate= DateTime.Now;
          this.UserToDate= DateTime.Now;
          this.ActuToDate= DateTime.Now;
          this.Result= string.Empty;
          this.ResultStr= string.Empty;
          this.IgnFail= string.Empty;
          this.ReorderFrm= DateTime.Now;
          this.ReorderTo= DateTime.Now;
          this.StopDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UserToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ActuToDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LastMsgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ResultStr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IgnFail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ReorderFrm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ReorderTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StopDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? StopTime { get; set; }
    }
}