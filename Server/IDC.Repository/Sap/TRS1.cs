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
    public partial class TRS1 
    {
        public TRS1()
        {
          this.ObjType= string.Empty;
          this.ApDocType= string.Empty;
          this.ApDocEntry= 0;
          this.ApDocOrdNo= 0;
          this.MeansType= 0;
          this.PayLineID= 0;
          this.PayDocType= 0;
          this.PayDocEntr= 0;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ApDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int ApDocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int ApDocOrdNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ApDocAdRef { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int MeansType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int PayLineID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int PayDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int PayDocEntr { get; set; }
    }
}