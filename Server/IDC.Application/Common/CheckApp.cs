using Dapper;
using IDC.Application.Common.Request;
using IDC.Application.Common.Response;
using IDC.Application.SSO;
using IDC.Infrastructure.AutoMapper;
using IDC.Infrastructure.Cipher;
using IDC.Infrastructure.Redis;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.NsapBase;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Common
{
    public class CheckApp
    {
        private readonly IRepositoryBase _repositoryBase;
        public CheckApp(IRepositoryBase repositoryBase)
        {
            _repositoryBase = repositoryBase;
            
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Password"></param>
        /// <param name="SystemKey"></param>
        /// <returns></returns>
        public async Task<TableData> Login(string Account, string Password, string SystemKey) 
        {
            var result = new TableData();
            var Parameters = new DynamicParameters();
            Parameters.Add("Account", Account);
            var user = await _repositoryBase.DetailAsync<IDC_User>("select * from IDC_User where Account=@Account", Parameters);
        
            if (user == null)
            {
                throw new Exception("账号不存在，请检查后重新输入。");
            }
            if (!user.SystemKey.Equals(SystemKey))
            {
                throw new Exception("系统密匙错误，请检查后重新输入。");
            }
            if (!Password.Equals(Encryption.Decrypt(user.Pwd)))
            {
                throw new Exception("密码错误，请检查后重新输入。");
            }
            var currentSession = new LoginUser
            {
                Account = user.Account,
                UserName = user.UserName,
                SystemName = user.SystemName,
                SystemKey = user.SystemKey,
                CreateTime = DateTime.Now,
                Token = Guid.NewGuid().ToString().GetHashCode().ToString("X"),
            };

            await RedisHelper.SetAsync(currentSession.Token, currentSession, DateTime.Now.AddDays(1) - DateTime.Now);
            result.Data = new { Token = currentSession.Token };
            return result;
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="Account"></param>
        /// <param name="Password"></param>
        /// <param name="SystemKey"></param>
        /// <returns></returns>
        public async Task<dynamic> LoginByLims(string Account, string Password, string SystemKey)
        {
            var result = new TableData();
            var Parameters = new DynamicParameters();
            Parameters.Add("Account", Account);
            var user = await _repositoryBase.DetailAsync<IDC_User>("select * from IDC_User where Account=@Account", Parameters);

            if (user == null)
            {
                throw new Exception("账号不存在，请检查后重新输入。");
            }
            if (!user.SystemKey.Equals(SystemKey))
            {
                throw new Exception("系统密匙错误，请检查后重新输入。");
            }
            if (!Password.Equals(Encryption.Decrypt(user.Pwd)))
            {
                throw new Exception("密码错误，请检查后重新输入。");
            }
            var currentSession = new LoginUser
            {
                Account = user.Account,
                UserName = user.UserName,
                SystemName = user.SystemName,
                SystemKey = user.SystemKey,
                CreateTime = DateTime.Now,
                Token = Guid.NewGuid().ToString().GetHashCode().ToString("X"),
            };

            await RedisHelper.SetAsync(currentSession.Token, currentSession, DateTime.Now.AddDays(1) - DateTime.Now);
            return new
            {
                access_token = currentSession.Token,
                token_type = "Bearer",
                expires_in = 24 * 60 * 60,
            };
        }

    }
}
