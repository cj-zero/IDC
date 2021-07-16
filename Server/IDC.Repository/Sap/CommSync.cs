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
    public partial class CommSync 
    {
        public CommSync()
        {
          this.TableName= string.Empty;
          this.DocEntry= 0;
          this.SyncStatus= 0;
          this.NewIndicator= string.Empty;
          this.NewComments= string.Empty;
          this.NewU_SL= string.Empty;
          this.CreatedTime= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int DocEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int SyncStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewIndicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewComments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NewU_SL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreatedTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? NewPrice { get; set; }
    }
}