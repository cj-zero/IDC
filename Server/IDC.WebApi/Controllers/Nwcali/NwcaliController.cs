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

        [HttpGet]
        public async Task<TableData> IsPass(string guid)
        {
            return await _app.IsPass(guid);
        }
    }
}
