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
    public partial class TPI3 
    {
        public TPI3()
        {
          this.ExtDocNum= string.Empty;
          this.RefObjType= string.Empty;
          this.IssueDate= DateTime.Now;
          this.Remark= string.Empty;
          this.CardCode= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RefDocEntr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? RefDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ExtDocNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string RefObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? IssueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CardCode { get; set; }
    }
}