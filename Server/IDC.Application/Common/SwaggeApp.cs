using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using IDC.Infrastructure.Export;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace IDC.Application.Common
{
    public class SwaggeApp
    {
        private readonly SwaggerGenerator _swaggerGenerator;
        public SwaggeApp(SwaggerGenerator swaggerGenerator) 
        {
            _swaggerGenerator = swaggerGenerator;
        }

        public async Task<byte[]> ExportSwagger(string type, string version) 
        {
            var data = _swaggerGenerator.GetSwagger(version);
            var temPath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "SwaggerExport.cshtml");
            switch (type)
            {
                case "pdf":
                    return await ExportAllHandler.Exporterpdf(data, temPath);

                case "word":

                    break;
                case "html":

                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
