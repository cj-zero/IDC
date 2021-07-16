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
    public partial class EJB1 
    {
        public EJB1()
        {
          this.Title= string.Empty;
          this.FirstName= string.Empty;
          this.Surname= string.Empty;
          this.CommID= string.Empty;
          this.DateOfBrth= DateTime.Now;
          this.DateOfSign= DateTime.Now;
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string CommID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateOfBrth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime? DateOfSign { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? AbsEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? LineNumEJD { get; set; }
    }
}