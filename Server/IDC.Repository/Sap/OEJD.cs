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
    public partial class OEJD 
    {
        public OEJD()
        {
          this.CRegNum= string.Empty;
          this.LFBSheet= string.Empty;
          this.LFBSheetPr= string.Empty;
          this.RegNum= string.Empty;
          this.CmpanyName= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CRegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LFBSheet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LFBSheetPr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CmpanyName { get; set; }
    }
}