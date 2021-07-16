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
    public partial class CPT1 
    {
        public CPT1()
        {
          this._Title= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string _Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WdtEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? _Left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? _Right { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? _Top { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? _Bottom { get; set; }
    }
}