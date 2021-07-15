using IDC.Application.Customer;
using IDC.Application.Customer.Request;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Customer
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Customer")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerApp _app;
        public CustomerController(CustomerApp app)
        {
            _app = app;
        }
        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetCustomerList([FromQuery] QueryCustomerListReq req)
        {
            try
            {
                return await _app.GetCustomerList(req);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
