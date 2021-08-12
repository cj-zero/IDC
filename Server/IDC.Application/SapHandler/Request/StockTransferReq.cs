using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.SapHandler.Request
{
    public class StockTransferReq
    {
        public NSAP.Entity.Store.storeOWTR storeOWTR { get; set; }
        public int UserID { get; set; }
        public string ations { get; set; }
        public string WhsCode { get; set; }
        public string _WhsCode { get; set; }
        public string AuditWhs { get; set; }
    }
}
