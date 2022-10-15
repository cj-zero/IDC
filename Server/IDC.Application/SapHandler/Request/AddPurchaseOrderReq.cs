using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.SapHandler.Request
{
    public class AddPurchaseOrderReq
    {
        public string DocNum { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string CntctCode { get; set; }
        public string SlpCode { get; set; }
        public string NumAtCard { get; set; }
        public string DocCur { get; set; }
        public string DocRate { get; set; }
        public string DocDate { get; set; }
        public string DocDueDate { get; set; }
        public string PartSupply { get; set; }
        public string Comments { get; set; }
        public string Remark { get; set; }
        public string Address2 { get; set; }
        public string Address { get; set; }
        public string U_FPLB { get; set; }
        public string U_SL { get; set; }
        public string GroupNum { get; set; }
        public string Indicator { get; set; }
        public string LicTradNum { get; set; }
        public string PayToCode { get; set; }
        public string ShipToCode { get; set; }
        //public string TrnspCode { get; set; }
        public string OwnerCode { get; set; }
        public string DocType { get; set; }
        public string DocTotal { get; set; }
        public string U_YGMD { get; set; }
        public string PeyMethod { get; set; }
        public string WhsCode { get; set; }
        public string CurSource { get; set; }
        public string U_CPH { get; set; }
        public string U_YSQX { get; set; }
        public string U_YF { get; set; }
        public string U_KDF { get; set; }
        public string U_BZF { get; set; }
        public string U_YCF { get; set; }
        public string U_OC_CN { get; set; }
        public string U_OC_AD { get; set; }
        public string U_OC_NA { get; set; }
        public string U_OC_TE { get; set; }
        public string U_PRX_SID { get; set; }
        public string U_PRX_TkNo { get; set; }
        public string U_PRX_SRVR { get; set; }
        public string U_ShipName { get; set; }
        public string U_SMAZ { get; set; }
        public string U_CCF { get; set; }
        public string U_THF { get; set; }
        public List<PurchaseAcctCode> PurchaseAcctCodeList { get; set; }

    }
    public class PurchaseAcctCode
    {
        public string AcctCode { get; set; }
        public string AcctName { get; set; }
        public string Details { get; set; }
        public string Price { get; set; }
        public string DiscPrcnt { get; set; }
        public string Rate { get; set; }
        public string PriceBefDi { get; set; }
        public string LineTotal { get; set; }
        public string BaseRef { get; set; }
        public string BaseType { get; set; }
        public string BaseEntry { get; set; }
        public string BaseLine { get; set; }
        public string U_WLLY { get; set; }
        public string U_YYFX { get; set; }
        public string U_ZXDH { get; set; }
        public string U_TYWP { get; set; }
        public string U_CPH { get; set; }
        public string U_TYSL { get; set; }
    }
}
