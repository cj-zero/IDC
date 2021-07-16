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
    public partial class OUDG 
    {
        public OUDG()
        {
          this.Name= string.Empty;
          this.Warehouse= string.Empty;
          this.ICTCard= string.Empty;
          this.CashAcct= string.Empty;
          this.CheckAcct= string.Empty;
          this.PrintRcpt= string.Empty;
          this.ShortRcpt= string.Empty;
          this.Address= string.Empty;
          this.Country= string.Empty;
          this.PrintHeadr= string.Empty;
          this.Phone1= string.Empty;
          this.Phone2= string.Empty;
          this.Fax= string.Empty;
          this.E_Mail= string.Empty;
          this.FrgnAddr= string.Empty;
          this.FrnPrntHdr= string.Empty;
          this.FrgnPhone1= string.Empty;
          this.FrgnPhone2= string.Empty;
          this.FrgnFax= string.Empty;
          this.DflTaxCode= string.Empty;
          this.FreeZoneNo= string.Empty;
          this.free1= string.Empty;
          this.UseTax= string.Empty;
          this.AdrsFromWh= string.Empty;
          this.Font= string.Empty;
          this.AssetInDoc= string.Empty;
          this.AttachPath= string.Empty;
          this.DflPTICode= string.Empty;
          this.Free4= string.Empty;
          this.Free2= string.Empty;
          this.Free3= string.Empty;
          this.TimeFormat= string.Empty;
          this.DateFormat= string.Empty;
          this.DateSep= string.Empty;
          this.DecSep= string.Empty;
          this.ThousSep= string.Empty;
          this.WallPaper= string.Empty;
          this.WllPprDsp= string.Empty;
          this.SkinType= string.Empty;
          this.HandleEDoc= string.Empty;
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
        public string Warehouse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SalePerson { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ICTCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CashAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CheckAcct { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? CreditCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintRcpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShortRcpt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrintHeadr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phone1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Phone2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string E_Mail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnAddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrnPrntHdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnPhone1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnPhone2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FrgnFax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflTaxCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FreeZoneNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string free1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UseTax { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AdrsFromWh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Font { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FontSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? BPLId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AssetInDoc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttachPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DflPTICode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Free3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DflPosCR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TimeFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DateSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DecSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ThousSep { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WallPaper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WllPprDsp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SkinType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? CharMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string HandleEDoc { get; set; }
    }
}