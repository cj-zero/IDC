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
    public partial class OWLS 
    {
        public OWLS()
        {
          this.WFID= string.Empty;
          this.WFName= string.Empty;
          this.TaskDesc= string.Empty;
          this.ObjType= string.Empty;
          this.Operation= string.Empty;
          this.ObjKey= string.Empty;
          this.EnterDate= DateTime.Now;
          this.TaskType= string.Empty;
          this.DueDate= DateTime.Now;
          this.UpdateDate= DateTime.Now;
          this.Owner= string.Empty;
          this.Status= string.Empty;
          this.Deleted= string.Empty;
          this.TaskName= string.Empty;
          this.isPicked= string.Empty;
          this.Attachment= string.Empty;
          this.ObjSubType= string.Empty;
          this.ForwardTo= string.Empty;
          this.WasRead= string.Empty;
          this.TrigParams= string.Empty;
          this.Key= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? WFInstID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WFID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WFName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaskDesc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Operation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? EnterDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? EnterTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaskType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DueDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DueTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UpdateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Owner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? Priority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogIns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Deleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? DuraDays { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? DuraHours { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TaskName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string isPicked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Attachment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AtcEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int? WorkListId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjSubType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ForwardTo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string WasRead { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string TrigParams { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Key { get; set; }
    }
}