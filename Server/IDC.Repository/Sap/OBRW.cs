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
    public partial class OBRW 
    {
        public OBRW()
        {
          this.Name= string.Empty;
          this.Url= string.Empty;
          this.App= string.Empty;
          this.Title= string.Empty;
          this.ShowWebTil= string.Empty;
          this.Size= string.Empty;
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
        public short? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string App { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowWebTil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Size { get; set; }
    }
}