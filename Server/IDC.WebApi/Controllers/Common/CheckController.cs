using IDC.Application.Common;
using IDC.Application.Common.Request;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Common
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Common")]
    public class CheckController : ControllerBase
    {
        private readonly CheckApp _checkApp; 
        public CheckController(CheckApp checkApp)
        {
            _checkApp = checkApp;
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<TableData> Login([FromBody] UserLoginReq req)
        {
            return await _checkApp.Login(req.Account,req.Password,req.SystemKey);
        }

    }
}
