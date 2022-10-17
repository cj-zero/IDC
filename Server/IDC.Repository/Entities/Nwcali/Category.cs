﻿using IDC.Repository.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Nwcali
{
    /// <summary>
    /// 分类表，也可用作数据字典。表示一个全集，比如：男、女、未知。关联的分类类型表示按什么进行的分类，如：按照性别对人类对象集
    /// </summary>
    public partial class Category : Entity
    {
        public Category()
        {
            this.Name = string.Empty;
            this.DtCode = string.Empty;
            this.DtValue = string.Empty;
            this.SortNo = 0;
            this.Description = string.Empty;
            this.TypeId = string.Empty;
            this.CreateTime = DateTime.Now;
            this.CreateUserId = string.Empty;
            this.CreateUserName = string.Empty;
            this.UpdateTime = DateTime.Now;
            this.UpdateUserId = string.Empty;
            this.UpdateUserName = string.Empty;
        }

        /// <summary>
        /// 名称
        /// </summary>
        [Description("名称")]
        public string Name { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        [Description("代码")]
        public string DtCode { get; set; }
        /// <summary>
        /// 通常与字典代码标识一致，但万一有不一样的情况呢？
        /// </summary>
        [Description("值")]
        public string DtValue { get; set; }
        /// <summary>
        /// 是否可用
        /// </summary>
        [Description("是否可用")]
        public bool Enable { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [Description("排序号")]
        public int SortNo { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Description("描述")]
        public string Description { get; set; }
        /// <summary>
        /// 分类ID
        /// </summary>
        [Description("分类标识")]
        public string TypeId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Description("创建时间")]
        public System.DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人ID
        /// </summary>
        [Description("创建人ID")]
        [Browsable(false)]
        public string CreateUserId { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Description("创建人")]
        public string CreateUserName { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Description("最后更新时间")]
        public System.DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 最后更新人ID
        /// </summary>
        [Description("最后更新人ID")]
        [Browsable(false)]
        public string UpdateUserId { get; set; }
        /// <summary>
        /// 最后更新人
        /// </summary>
        [Description("最后更新人")]
        public string UpdateUserName { get; set; }
    }
}
