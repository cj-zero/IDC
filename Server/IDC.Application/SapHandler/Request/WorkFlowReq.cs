using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.SapHandler.Request
{
    public class WorkFlowReq
    {
        public string jobName { get; set; }
        public int funcID { get; set; }
        public int userID { get; set; }
        public byte[] jobdata { get; set; }
        public string remarks { get; set; }
        public int sboID { get; set; }
        public string carCode { get; set; }
        public string carName { get; set; }
        public double docTotal { get; set; }
        public int baseType { get; set; }
        public int baseEntry { get; set; }
        public string assemblyName { get; set; }
        public string className { get; set; }
    }
}
