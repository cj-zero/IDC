using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.NsapBone
{
    [ConnectionString("NsapBoneDbContext", "NsapBoneReadDbContext")]
    public class product_store_relation
    {
        public int sbo_id { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
    }
}
