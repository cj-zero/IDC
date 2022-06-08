using IDC.Application.Material;
using IDC.Application.Material.Request;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Material
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Material")]
    public class MaterialController : ControllerBase
    {
        private readonly MaterialApp _app;
        public MaterialController(MaterialApp app)
        {
            _app = app;
        }

        /// <summary>
        /// 获取物料列表
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetMaterialList([FromQuery]QueryMaterialListReq req) 
        {
            return await _app.GetMaterialList(req);
        }

        /// <summary>
        /// 根据guid获取下位机程序的版本信息
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetXWJVersion([FromQuery] string guid)
        {
            var result = new TableData();

            try
            {
                result = await _app.GetXWJVersion(guid);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }

            return result;
        }

        /// <summary>
        /// 根据设备guid获取中位机软件版本
        /// </summary>
        /// <param name="guid">设备guid</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetZWJSoftwareVersion([FromQuery] string guid)
        {
            var result = new TableData();
            try
            {
                result = await _app.GetZWJSoftwareVersion(guid);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }

            return result;
        }
        
        /// <summary>
        /// 根据设备guid获取下位机软件版本
        /// </summary>
        /// <param name="guid">设备guid</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetXWJSoftwareVersion([FromQuery] string guid)
        {
            var result = new TableData();
            try
            {
                result = await _app.GetXWJSoftwareVersion(guid);
            }
            catch(Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }

            return result;
        }
    }
}
