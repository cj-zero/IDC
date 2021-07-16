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
    public partial class IWZ1 
    {
        public IWZ1()
        {
          this.ActName= string.Empty;
          this.ExecutLine= string.Empty;
          this.ActRevCncl= string.Empty;
          this.RevToAct= string.Empty;
          this.RvCaclDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActFrmBlnc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExecutLine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ActRevCncl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RevToAct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActDiffBal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? RvCaclDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ErrReason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? ActLastBal { get; set; }
    }
}