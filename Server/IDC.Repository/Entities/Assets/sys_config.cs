using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class sys_config
    {
        public long id { get; set; }
        public string key { get; set; }
        public string val { get; set; }
        public string remark { get; set; }
    }
}
