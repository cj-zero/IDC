using DotNetCore.CAP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Common
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Common")]
    public class UserController : ControllerBase
    {
        private readonly ICapPublisher _capPublisher;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="capPublisher"></param>
        public UserController(ICapPublisher capPublisher)
        {
            _capPublisher = capPublisher;
        }
        /// <summary>
        /// 发布
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<string> Publish()
        {
            await _capPublisher.PublishAsync("bim.core.api", DateTime.Now);
            return "发送成功";
        }
        /// <summary>
        /// 订阅
        /// </summary>
        /// <param name="date"></param>
        [HttpGet, Route("receive")]
        [CapSubscribe("bim.core.api")]
        public void Receive(string date)
        {
            Console.WriteLine($"接收到订阅:{date}");
        }
    }
}
