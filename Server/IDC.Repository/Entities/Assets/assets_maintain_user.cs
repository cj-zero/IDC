using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Assets
{
    public partial class assets_maintain_user
    {
        public int Id { get; set; }
        public int assets_id { get; set; }
        public int user_id { get; set; }
        public int? passport_id { get; set; }
    }
}
