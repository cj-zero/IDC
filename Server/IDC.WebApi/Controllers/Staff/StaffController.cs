using IDC.Application.Staff;
using IDC.Application.Staff.Request;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Staff
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Staff")]
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
