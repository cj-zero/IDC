using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.WMS.Request
{
    public class BillSerialNumberChooseItem
    {
            /// <summary>
            /// 系统编号
            /// </summary>
            
            public string SysSerial { get; set; }

            /// <summary>
            /// 制造商序列号
            /// </summary>
            
            public string SuppSerial { get; set; }

            /// <summary>
            /// 序列号
            /// </summary>
            
            public string IntrSerial { get; set; }

    }
}
