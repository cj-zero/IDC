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
    public partial class OMSG 
    {
        public OMSG()
        {
          this.Signature= string.Empty;
          this.UseCompSig= string.Empty;
          this.DummySig= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Signature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseCompSig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DummySig { get; set; }
    }
}