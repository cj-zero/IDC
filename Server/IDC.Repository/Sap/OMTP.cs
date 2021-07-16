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
    public partial class OMTP 
    {
        public OMTP()
        {
          this.MatType= string.Empty;
          this.Descrip= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MatType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Descrip { get; set; }
    }
}