using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.PurchaseOrder.Response
{
   public class GetOpdnByOporResp
    {
        public string sbo_id { get; set; }
        public string DocEntry { get; set; }
        public string pdn { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public decimal Quantity { get; set; }
        public decimal linetotal { get; set; }
         public DateTime createDate { get; set; }
        public string WhsName { get; set; }
        public string WhsCode { get; set; }
        public string SlpName { get; set; }
        public decimal price { get; set; }

    }
}
