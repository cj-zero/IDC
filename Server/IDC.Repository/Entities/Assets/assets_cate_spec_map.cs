using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_cate_spec_map
    {
        public int id { get; set; }
        public int category_id { get; set; }
        public int spec_id { get; set; }
        public Nullable<int> old_category_id { get; set; }
    }
}
