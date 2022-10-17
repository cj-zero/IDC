using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Common.Request
{
    public class LimsUserLoginReq
    {
        public string grant_type { get; set; }
   
        public string client_id { get; set; }

        public string client_secret { get; set; }

        public string scope { get; set; }

        public void Trim()
        {
            if (string.IsNullOrEmpty(client_id))
            {
                throw new Exception("client_id不能为空");
            }

            if (string.IsNullOrEmpty(client_secret))
            {
                throw new Exception("client_secret不能为空");
            }
            client_id = client_id.Trim();
            client_secret = client_secret.Trim();
            if (!string.IsNullOrEmpty(scope)) scope = scope.Trim();

        }
    }
}
