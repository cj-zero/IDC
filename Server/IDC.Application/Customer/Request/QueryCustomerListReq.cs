using IDC.Application.Common.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDC.Application.Customer.Request
{
    public class QueryCustomerListReq : PageReq
    {
        /// <summary>
        /// 是否客户
        /// </summary>
        public bool IsCustomer { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }
    }
}
