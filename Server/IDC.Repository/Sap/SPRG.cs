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
    public partial class SPRG 
    {
        public SPRG()
        {
          this.Name= string.Empty;
          this.FileName= string.Empty;
          this.Path= string.Empty;
          this.Params= string.Empty;
          this.OPRTION= string.Empty;
          this.WIN_STYLE= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Params { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OPRTION { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WIN_STYLE { get; set; }
    }
}