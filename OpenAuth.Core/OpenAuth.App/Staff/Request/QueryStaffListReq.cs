using OpenAuth.App.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAuth.App.Staff.Request
{
    public class QueryStaffListReq : PageReq
    {
        /// <summary>
        /// 物料编码
        /// </summary>
        public string StaffName { get; set; }

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
