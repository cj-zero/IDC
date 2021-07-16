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
    public partial class OUGR 
    {
        public OUGR()
        {
          this.GroupName= string.Empty;
          this.GroupDec= string.Empty;
          this.Allowences= string.Empty;
          this.StartDate= DateTime.Now;
          this.DueDate= DateTime.Now;
          this.GroupType= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupDec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Allowences { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? TPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? StartDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public short? CockpitId { get; set; }
    }
}