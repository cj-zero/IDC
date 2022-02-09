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
    }
}
