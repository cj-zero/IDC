using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_positioner_bind
    {
        public int Id { get; set; }
        public int assets_id { get; set; }
        public int positioner_assets_id { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
    }
}
