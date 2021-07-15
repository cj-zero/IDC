using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.SapHandler.Request
{
    public class RcvddetailReq
    {
        public string CardCode { get; set; }
        public string CntctCode { get; set; }
        public string SlpCode { get; set; }
        public string NumAtCard { get; set; }
        public string DocCur { get; set; }
        public string DocDate { get; set; }
        public string DocDueDate { get; set; }
        public string PartSupply { get; set; }
        public string Comments { get; set; }
        public string Address2 { get; set; }
        public string Address { get; set; }
        public string U_FPLB { get; set; }
        public string U_SL { get; set; }
        public string GroupNum { get; set; }
        public string Indicator { get; set; }
        public string LicTradNum { get; set; }
        public string PayToCode { get; set; }
        public string ShipToCode { get; set; }
        public string TrnspCode { get; set; }
        public string OwnerCode { get; set; }
        public string DocType { get; set; }
        public string CustomFields { get; set; }
        public string U_YGMD { get; set; }
        public string PeyMethod { get; set; }
        public string billBaseType { get; set; }
        public string WhsCode { get; set; }
        public List<BillSalesDetail> billSalesDetails { get; set; }
        public List<BillSalesAcctCode> billSalesAcctCode { get; set; }
    }
    public class BillSalesDetail 
    {
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public string Quantity { get; set; }
        public string BaseEntry { get; set; }
        public string BaseLine { get; set; }
        public string billBaseType { get; set; }
        public string Price { get; set; }
        public string U_PDXX { get; set; }
    }

    public class BillSalesAcctCode
    {
        public string billBaseType { get; set; }
        public string BaseEntry { get; set; }
        public string BaseLine { get; set; }
        public string AcctCode { get; set; }
        public string Details { get; set; }
        public string Price { get; set; }
    }
}
