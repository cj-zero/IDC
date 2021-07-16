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
    public partial class OMPO 
    {
        public OMPO()
        {
          this.ObjectId= 0;
          this.ObAbsEntry= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int ObjectId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObAbsEntry { get; set; }
    }
}