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
    [Table("sale_transport")]
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