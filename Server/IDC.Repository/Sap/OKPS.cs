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
    public partial class OKPS 
    {
        public OKPS()
        {
          this.KpsName= string.Empty;
          this.KpsType= string.Empty;
          this.CreateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KpsName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string KpsType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FieldsNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
    }
}