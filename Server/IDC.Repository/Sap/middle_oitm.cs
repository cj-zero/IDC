﻿using System;
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
    public partial class middle_oitm 
    {
        public middle_oitm()
        {
        }

        
        /// <summary>
        /// 库存中的实际数量
        /// </summary>
        [Description("库存中的实际数量")]
        public decimal? OnHand { get; set; }
        /// <summary>
        /// 按客户的订单数量
        /// </summary>
        [Description("按客户的订单数量")]
        public decimal? IsCommited { get; set; }
        /// <summary>
        /// 供应商订购数量
        /// </summary>
        [Description("供应商订购数量")]
        public decimal? OnOrder { get; set; }
        /// <summary>
        /// 最小库存量
        /// </summary>
        [Description("最小库存量")]
        public decimal? MinLevel { get; set; }
        /// <summary>
        /// 最后估算价格
        /// </summary>
        [Description("最后估算价格")]
        public decimal? LstEvlPric { get; set; }
    }
}