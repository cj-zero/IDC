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
    public partial class middle_oitw 
    {
        public middle_oitw()
        {
          this.WhsCode= string.Empty;
        }

        
        /// <summary>
        /// 仓库代码
        /// </summary>
        [Description("仓库代码")]
        public string WhsCode { get; set; }
        /// <summary>
        /// 库存中
        /// </summary>
        [Description("库存中")]
        public decimal? OnHand { get; set; }
        /// <summary>
        /// 已定义
        /// </summary>
        [Description("已定义")]
        public decimal? IsCommited { get; set; }
        /// <summary>
        /// 已订购
        /// </summary>
        [Description("已订购")]
        public decimal? OnOrder { get; set; }
        /// <summary>
        /// 最小库存
        /// </summary>
        [Description("最小库存")]
        public decimal? MinStock { get; set; }
    }
}