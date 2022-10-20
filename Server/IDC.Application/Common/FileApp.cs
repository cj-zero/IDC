using IDC.Infrastructure.Returned;
using IDC.Repository.Entities.Nwcali;
using IDC.Repository.HuaweiOBS;
using Microsoft.AspNetCore.Http;
using OBS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Common
{
    public class FileApp
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName">上传路径</param>
        /// <param name="file">以文件形式上传</param>
        /// <param name="stream">以流形式上传</param>
        /// <returns></returns>
        public async Task<TableData> UploadFileToHuaweiOBS(string fileName, IFormFile file = null, Stream stream = null)
        {
            var result = new TableData();
            var obsHelper = new HuaweiOBSHelper();
            if (stream == null)
            {
                stream = file?.OpenReadStream();
            }
            var response = obsHelper.PutObject(fileName, null, stream, out string objectKey);

            result.Data = new
            {
                FileName = objectKey,
                FilePath = response.ObjectUrl
            };
        
            return result;

        }
    }
}
