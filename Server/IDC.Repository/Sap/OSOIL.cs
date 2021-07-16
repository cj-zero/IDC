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
    public partial class OSOIL 
    {
        public OSOIL()
        {
          this.AbsEntry= 0;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? WizardId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SOINum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int AbsEntry { get; set; }
    }
}