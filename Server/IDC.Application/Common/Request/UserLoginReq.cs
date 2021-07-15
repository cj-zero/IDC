using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Common.Request
{
    public class UserLoginReq
    {
        public string Account { get; set; }

        public string Password { get; set; }

        public string SystemKey { get; set; }

        public void Trim()
        {
            if (string.IsNullOrEmpty(Account))
            {
                throw new Exception("用户名不能为空");
            }

            if (string.IsNullOrEmpty(Password))
            {
                throw new Exception("密码不能为空");
            }
            Account = Account.Trim();
            Password = Password.Trim();
            if (!string.IsNullOrEmpty(SystemKey)) SystemKey = SystemKey.Trim();
        }
    }
}
