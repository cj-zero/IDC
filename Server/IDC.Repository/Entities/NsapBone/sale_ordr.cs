using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBone
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBoneDbContext","NsapBoneReadDbContext")]
    public partial class sale_ordr
    {
        /// <summary>
        /// 账套
        /// </summary>
        [Description("")]
        public int sbo_id { get; set; }
        /// <summary>
        /// 销售订单id
        /// </summary>
        [Description("")]
        public int? DocEntry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public uint DocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? SlpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CntctCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Ref1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_YWY { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_FPLB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_SL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Indicator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DocDueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PartSupply { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Printed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Handwrtten { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? GroupNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? TaxDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? DocRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocCur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CANCELED { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string U_ERPFrom { get; set; }
        /// <summary>
        /// 如果是商城订单记录商城单号
        /// </summary>
        [Description("")]
        public string U_EshopNo { get; set; }
        /// <summary>
        /// 订单货物签收状态 1为已签收 否则为0
        /// </summary>
        [Description("")]
        public int? U_ShipStatus { get; set; }
        [Description("")]
        public string InvntSttus { get; set; }
        [Description("")]
        public string VatSum { get; set; }
        [Description("")]
        public string DiscPrcnt { get; set; }
        [Description("")]
        public string DiscSum { get; set; }
        [Description("")]
        public string PaidToDate { get; set; }
        [Description("")]
        public string GrosProfit { get; set; }
    }
}