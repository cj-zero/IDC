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
    public partial class SRA3 
    {
        public SRA3()
        {
          this.ObjType= string.Empty;
          this.ObjCode= string.Empty;
          this.Name= string.Empty;
          this.SendInter= string.Empty;
          this.SendEmail= string.Empty;
          this.SendSMS= string.Empty;
          this.Email= string.Empty;
          this.Number= string.Empty;
          this.AttachDAG= string.Empty;
          this.AttachPDF= string.Empty;
          this.AttachHTML= string.Empty;
          this.AttachXML= string.Empty;
          this.ShowResult= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendInter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string SendSMS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttachDAG { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttachPDF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttachHTML { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string AttachXML { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ShowResult { get; set; }
    }
}