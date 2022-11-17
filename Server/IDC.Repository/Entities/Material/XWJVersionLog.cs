using IDC.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Material
{
    public class XWJVersionLog : BaseEntity<int>
    {
        public string ComputerName { get; set; }
        public string Guid { get; set; }
        public string Sn { get; set; }
        public string Version { get; set; }
        public string UserId { get; set; }
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
