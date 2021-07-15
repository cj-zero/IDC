using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IDC.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Common
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Common")]
    public class SwaggerController : ControllerBase
    {
        private readonly SwaggeApp _swaggeApp;
        public SwaggerController(SwaggeApp swaggeApp) 
        {
            _swaggeApp = swaggeApp;
        }
        /// <summary>
        /// 导出接口离线文档
        /// </summary>
        /// <param name="type">文件类型</param>
        /// <param name="version">版本号V1</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<FileResult> ExportDocument(string type,string version)
        {
            var data = await _swaggeApp.ExportSwagger(type,version);
            return File(data, "application/pdf");
        }
    }
}
