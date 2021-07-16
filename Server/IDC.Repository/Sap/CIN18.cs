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
    public partial class CIN18 
    {
        public CIN18()
        {
          this.ObjectType= string.Empty;
          this.ExpDeclDat= DateTime.Now;
          this.ExpRegDate= DateTime.Now;
          this.LadBillNum= string.Empty;
          this.LadBillDat= DateTime.Now;
          this.MerchLeftD= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LogInstanc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string ObjectType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExpDocType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExpDeclNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExpDeclDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExpNature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? ExpRegNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? ExpRegDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string LadBillNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? LadBillDat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? MerchLeftD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LadBillTyp { get; set; }
    }
}