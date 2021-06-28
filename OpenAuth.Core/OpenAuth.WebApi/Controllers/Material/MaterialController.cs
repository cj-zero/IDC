using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenAuth.App.Material;
using OpenAuth.App.Material.Request;
using OpenAuth.App.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenAuth.WebApi.Controllers.Material
{
    [Route("api/[controller]/[action]")]
    [ApiController]
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
            try
            {
                return await _app.GetMaterialList(req);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
                
        }
    }
}
