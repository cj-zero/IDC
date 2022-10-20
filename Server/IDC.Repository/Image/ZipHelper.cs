using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Image
{
    public class ZipHelper
    {
        /// <summary>
        /// 多个文件压缩
        /// </summary>
        /// <param name="streams">流字典</param>
        public static MemoryStream PackageManyZip(Dictionary<string, Stream> streams)
        {
            byte[] buffer = new byte[6500];
            MemoryStream returnStream = new MemoryStream();
            var zipMs = new MemoryStream();
            using (ZipOutputStream zipStream = new ZipOutputStream(zipMs))
            {
                zipStream.SetLevel(9);
                foreach (var kv in streams)
                {
                    string fileName = kv.Key;
                    using (var streamInput = kv.Value)
                    {
                        streamInput.Position = 0;
                        zipStream.PutNextEntry(new ZipEntry(fileName + ".jpg"));
                        while (true)
                        {
                            var readCount = streamInput.Read(buffer, 0, buffer.Length);
                            if (readCount > 0)
                                zipStream.Write(buffer, 0, readCount);
                            else
                                break;
                        }
                        zipStream.Flush();
                    }
                }
                zipStream.Finish();
                zipMs.Position = 0;
                zipMs.CopyTo(returnStream, 5600);
            }
            returnStream.Position = 0;
            return returnStream;
        }
    }
}
