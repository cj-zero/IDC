using IDC.Application.Common;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Common
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Common")]
    public class FileController : ControllerBase
    {
        private readonly FileApp _app;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public FileController(FileApp app)
        {
            _app = app;
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> Upload()
        {
            var result = new TableData();
            try
            {
                var files = Request.Form.Files;
                var file = files[0];
                //保存文件
                var fileResp = await _app.UploadFileToHuaweiOBS(file.FileName, file);
                result.Data = fileResp;
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }
            return result;
        }

    }
}
