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
    public partial class MysqlIformation 
    {
        public MysqlIformation()
        {
          this.OrderType= string.Empty;
          this.ItemCode= string.Empty;
          this.OrderNo= string.Empty;
          this.TableName= string.Empty;
          this.Ustate= string.Empty;
          this.CreateDate= DateTime.Now;
        }

        
        /// <summary>
        /// 这个是外挂组人建的表
        /// </summary>
        [Description("这个是外挂组人建的表")]
        public string OrderType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string OrderNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TableName { get; set; }
        /// <summary>
        /// 0未更新mysql上,1已更新
        /// </summary>
        [Description("0未更新mysql上,1已更新")]
        public string Ustate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
    }
}