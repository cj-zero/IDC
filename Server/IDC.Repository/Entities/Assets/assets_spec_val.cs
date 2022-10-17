using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_spec_val
    {
        public int id { get; set; }
        public int assets_id { get; set; }
        public int spec_id { get; set; }
        public string spec_val { get; set; }
    }
}
