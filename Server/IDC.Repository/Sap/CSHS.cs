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
    public partial class CSHS 
    {
        public CSHS()
        {
          this.FormID= string.Empty;
          this.ItemID= string.Empty;
          this.ColID= string.Empty;
          this.Refresh= string.Empty;
          this.FieldID= string.Empty;
          this.FrceRfrsh= string.Empty;
          this.ByField= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FormID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ColID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ActionT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? QueryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Refresh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrceRfrsh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ByField { get; set; }
    }
}