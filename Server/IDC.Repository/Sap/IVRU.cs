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
    public partial class IVRU 
    {
        public IVRU()
        {
          this.SourceDB= string.Empty;
          this.UtilityDB= string.Empty;
          this.UpdDate= DateTime.Now;
          this.TblHINM= string.Empty;
          this.TblHITM= string.Empty;
          this.TblHITW= string.Empty;
          this.TblFINM= string.Empty;
          this.TblFITM= string.Empty;
          this.TblFITW= string.Empty;
          this.Comment= string.Empty;
          this.StrFld= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SourceDB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string UtilityDB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? IVLGEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TblHINM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TblHITM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TblHITW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TblFINM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TblFITM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TblFITW { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrSeqHINM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? TrSeqOINM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TrIdUtil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? TrIdProd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string StrFld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? NumFld { get; set; }
    }
}