using IDC.Application.Common.Response;
using IDC.Infrastructure.Returned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.SSO
{
    public interface IAuth
    {
        /// <summary>
        /// 检验token是否正确
        /// </summary>
        /// <returns></returns>
        bool CheckLogin();
        /// <summary>
        /// 获取当前登录的用户信息
        /// </summary>
        /// <returns></returns>
        LoginUser GetCurrentUser();
    }
}
