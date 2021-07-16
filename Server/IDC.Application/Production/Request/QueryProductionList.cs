using IDC.Application.Common.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Production.Request
{
    public class QueryProductionList: PageReq
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
