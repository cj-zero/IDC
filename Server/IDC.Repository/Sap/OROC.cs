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
    public partial class OROC 
    {
        public OROC()
        {
          this.BoeStatus= string.Empty;
          this.Descript= string.Empty;
          this.FileFormat= string.Empty;
          this.BankCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? OccurCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MovemnCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BoeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descript { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string BankCode { get; set; }
    }
}