using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenAuth.App.Response;
using OpenAuth.App.Staff;
using OpenAuth.App.Staff.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenAuth.WebApi.Controllers.Staff
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly StaffApp _app;
        public StaffController(StaffApp app)
        {
            _app = app;
        }
        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetStaffList([FromQuery]QueryStaffListReq req) 
        {
            try
            {
                return await _app.GetStaffList(req);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
