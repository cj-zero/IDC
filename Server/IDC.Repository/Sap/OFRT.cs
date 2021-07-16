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
    public partial class OFRT 
    {
        public OFRT()
        {
          this.Name= string.Empty;
          this.DocType= string.Empty;
          this.MoveChk1= string.Empty;
          this.MoveChk2= string.Empty;
          this.Title_1= string.Empty;
          this.Title_2= string.Empty;
          this.ShowMiss= string.Empty;
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
        public string DocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? FRTCounter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MoveChk1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string MoveChk2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MoveTo_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? MoveTo_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Title_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Title_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowMiss { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ToTitle_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? ToTitle_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DimCode { get; set; }
    }
}