using IDC.Application.Common.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.SSO
{
    public class Auth: IAuth
    {

        private IHttpContextAccessor _httpContextAccessor;
        public Auth(IHttpContextAccessor httpContextAccessor) 
        {
            _httpContextAccessor = httpContextAccessor;
        }
        /// <summary>
        /// 检验token是否正确
        /// </summary>
        /// <returns></returns>
        public bool CheckLogin()
        {
            var tokenObj = RedisHelper.Get<LoginUser>(GetToken());
            if (tokenObj != null)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 获取传入token
        /// </summary>
        /// <returns></returns>
        private string GetToken()
        {
            string token = _httpContextAccessor.HttpContext.Request.Query[Define.TOKEN_NAME];
            if (!String.IsNullOrEmpty(token)) return token;

            token = _httpContextAccessor.HttpContext.Request.Headers[Define.TOKEN_NAME];
            if (!String.IsNullOrEmpty(token)) return token;

            string limsToken = _httpContextAccessor.HttpContext.Request.Query["Authorization"];
            if (!String.IsNullOrEmpty(limsToken)) return limsToken.Replace("Bearer", "").Trim();

            limsToken = _httpContextAccessor.HttpContext.Request.Headers["Authorization"];
            if (!String.IsNullOrEmpty(limsToken)) return limsToken.Replace("Bearer", "").Trim();

            var cookie = _httpContextAccessor.HttpContext.Request.Cookies[Define.TOKEN_NAME];
            return cookie ?? String.Empty;
        }
        /// <summary>
        /// 获取当前登录的用户信息
        /// </summary>
        /// <returns></returns>
        public LoginUser GetCurrentUser()
        {
            var user = RedisHelper.Get<LoginUser>(GetToken());
            if (user != null)
            {
                return user;
            }
            return null;
        }
    }
}
