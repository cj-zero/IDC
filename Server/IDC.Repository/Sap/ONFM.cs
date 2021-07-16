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
    public partial class ONFM 
    {
        public ONFM()
        {
          this.NfmName= string.Empty;
          this.NfmDescrip= string.Empty;
          this.UpdateDate= DateTime.Now;
          this.NfmCode= string.Empty;
          this.NfmTW= string.Empty;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NfmName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NfmDescrip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public short? UserSign2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NfmCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string NfmTW { get; set; }
    }
}