using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.NsapBone
{
    [ConnectionString("NsapBoneDbContext", "NsapBoneReadDbContext")]
    public class product_store_detail
    {
        public int sbo_id { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int LineNum { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public decimal Quantity { get; set; }
        public decimal PlannedQty { get; set; }
        public int IssueType { get; set; }
        public string FromWareHouse { get; set; }
        public string ToWareHouse { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
