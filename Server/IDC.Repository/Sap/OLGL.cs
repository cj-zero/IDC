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
    public partial class OLGL 
    {
        public OLGL()
        {
          this.SrcObjType= string.Empty;
          this.SrcObjAbs= 0;
          this.ObjType= string.Empty;
          this.PrintDate= DateTime.Now;
          this.PrBrand= string.Empty;
          this.PrType= string.Empty;
          this.PrModel= string.Empty;
          this.PrFwVer= string.Empty;
          this.PrDllVer= string.Empty;
          this.FisSeries= string.Empty;
          this.FisNumber= string.Empty;
          this.DocNumber= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SrcObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int SrcObjAbs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? PrintDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? PrintTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrBrand { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrFwVer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string PrDllVer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FisSeries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FisNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string DocNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FisUser { get; set; }
    }
}