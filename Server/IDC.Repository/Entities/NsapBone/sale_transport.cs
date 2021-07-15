using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.NsapBone
{
    /// <summary>
	/// 
	/// </summary>
    [ConnectionString("NsapBoneDbContext","NsapBoneReadDbContext")]
    public partial class sale_transport 
    {
        public sale_transport()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int Base_DocEntry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int Base_DocType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int SboId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        [Browsable(false)]
        public int Buy_DocEntry { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int? Buy_SboId { get; set; }
    }
}