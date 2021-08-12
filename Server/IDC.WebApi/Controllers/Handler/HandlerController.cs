using IDC.Application.SapHandler;
using IDC.Application.SapHandler.Request;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Handler
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Handler")]
    public class HandlerController : ControllerBase
    {
        private readonly HandlerApp _handlerApp;

        public HandlerController(HandlerApp handlerApp) 
        {
            _handlerApp = handlerApp;
        }
        /// <summary>
        /// 同步采购订单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Response> Rcvddetail(RcvddetailReq model) 
        {
            return await _handlerApp.Rcvddetail(model);
        }


    }
}
