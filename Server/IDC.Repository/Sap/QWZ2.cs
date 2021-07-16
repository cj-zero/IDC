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
    public partial class QWZ2 
    {
        public QWZ2()
        {
          this.FileCode= string.Empty;
          this.FieldAlias= string.Empty;
          this.Title= string.Empty;
          this.SortType= string.Empty;
          this.GroupBy= string.Empty;
          this.CalcField= string.Empty;
          this.IsCalc= string.Empty;
          this.TmpAlias= string.Empty;
          this.TmpDescr= string.Empty;
          this.Fld2Alias= string.Empty;
          this.FileCode2= string.Empty;
          this.FldCnstVal= string.Empty;
          this.Fld2CnsVal= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FieldAlias { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? SortOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SortType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string GroupBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AgregType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CalcField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string IsCalc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TmpAlias { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TmpDescr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fld2Alias { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FileCode2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Agreg2Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? FldOp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FldCnstVal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Fld2CnsVal { get; set; }
    }
}