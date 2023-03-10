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
    public partial class ITM12 
    {
        public ITM12()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? BcdEntDft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? PkgCodeDft { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Height1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Hght1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Height2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Hght2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Width1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Wdth1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Width2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Wdth2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Length1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Len1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Length2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Len2Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Volume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? VolUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Weight1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Wght1Unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public decimal? Weight2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Wght2Unit { get; set; }
    }
}