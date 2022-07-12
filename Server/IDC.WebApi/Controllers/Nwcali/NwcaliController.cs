using IDC.Application.Nwcali;
using IDC.Infrastructure.Returned;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Nwcali
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Nwcali")]
    public class NwcaliController : ControllerBase
    {
        private readonly NwcaliApp _app;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public NwcaliController(NwcaliApp app)
        {
            _app = app;
        }

        /// <summary>
        /// 是否通过烤机
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> IsPass(string guid)
        {
            return await _app.IsPass(guid);
        }
        /// <summary>
        /// 是否通过校准
        /// </summary>
        /// <param name="wo"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> CheckCalibration(string wo)
        {
            return await _app.CheckCalibration(wo);
        }

        /// <summary>
        /// GUID是否和烤机绑定的数据一致
        /// </summary>
        /// <param name="wo"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> CheckBinding(string wo, string guid)
        {
            return await _app.CheckBinding(wo, guid);
        }
    }
}
