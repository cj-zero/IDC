﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OpenAuth.Repository.Core;

namespace OpenAuth.Repository.Domain
{
    /// <summary>
	/// 
	/// </summary>
    [Table("base_post")]
    public partial class base_post : Entity
    {
        public base_post()
        {
          this.post_nm= string.Empty;
          this.post_desc= string.Empty;
          this.upd_dt= DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public int post_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string post_nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string post_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public bool valid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public System.DateTime upd_dt { get; set; }
    }
}