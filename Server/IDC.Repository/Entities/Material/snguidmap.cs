using IDC.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Material
{
    public class snguidmap : BaseEntity<int>
    {
        public string Guid { get; set; }
        public string Sn { get; set; }
        public DateTime? CreateTime { get; set; }
        public override void GenerateDefaultKeyVal()
        {

        }

        public override bool KeyIsNull()
        {
            return Id == 0;
        }
    }
}
