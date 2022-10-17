using IDC.Application.Common;
using IDC.Application.Nwcali;
using IDC.Application.Nwcali.Request;
using IDC.Infrastructure.Returned;
using IDC.Repository.Helps;
using IDC.Repository.Image;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IDC.WebApi.Controllers.Nwcali
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Nwcali")]
    public class LaboratoryAssetController : ControllerBase
    {
        private readonly LaboratoryAssetApp _app;
        private readonly FileApp _fileApp;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public LaboratoryAssetController(LaboratoryAssetApp app, FileApp fileApp)
        {
            _app = app;
            _fileApp = fileApp;
        }
        /// <summary>
        /// 获取万用表资产信息
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetMultimeterAssetInfo(string sn)
        {
            var result = new TableData();
            try
            {
                return await _app.GetMultimeterAssetInfo(sn);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }
            return result;
        }
        /// <summary>
        /// 获取资产信息
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<TableData> GetCalibrationAssetInfo([FromQuery] List<string> asset_number)
        {
            var result = new TableData();
            try
            {
                result = await _app.GetCalibrationAssetInfo(asset_number);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 加载资产列表
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> Load(QueryassetListReq request)
        {
            var result = new TableData();
            try
            {
                result = await _app.Load(request);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 添加资产
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> Add(AddOrUpdateassetReq req)
        {
            var result = new TableData();
            try
            {
                await _app.Add(req);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }
            return result;
        }
        /// <summary>
        /// 修改资产
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> Update(AddOrUpdateassetReq req)
        {
            var result = new TableData();
            try
            {
                await _app.Update(req);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }
            return result;
        }
        /// <summary>
        /// 根据id获取分类详情
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> GetAssetCategoryDetails(string categoryIds)
        {
            var result = new TableData();
            try
            {
                await _app.GetAssetCategoryDetails(categoryIds);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }
            return result;
        }
        /// <summary>
        /// 获取单个资产
        /// </summary>
        /// <param name="sn"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<TableData> GetAsset(int assetid)
        {
            var result = new TableData();
            try
            {
                return  await _app.GetAsset(assetid);
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }
            return result;
        }
        /// <summary>
        /// 上传资产文件
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
                var fileResp = await _fileApp.UploadFileToHuaweiOBS($"nwcail/asset/{file.FileName}", file);
                result.Data = fileResp;
            }
            catch (Exception ex)
            {
                result.Code = 500;
                result.Message = ex.InnerException?.Message ?? ex.Message;
            }
            return result;
        }

        /// <summary>
        /// 批量导出实验室资产二维码
        /// </summary>
        /// <param name="ids">实验室资产id,存在多个id ,用因为逗号隔开 </param>
        [HttpGet]
        public async Task<HttpResponseMessage> CreateAssetsQrCode(string ids)
        {
            TableData apiResult = new TableData();

            var assetList = await _app.GetLaboratoryAssetList(ids);

            Dictionary<string, Stream> streamList = new Dictionary<string, Stream>();
            string imgFilePath = string.Empty;
            string directory = AppDomain.CurrentDomain.BaseDirectory;

            imgFilePath = string.Format(@"{0}image\app.png", directory);
            foreach (var asset in assetList)
            {
                //var guid = string.IsNullOrWhiteSpace(asset.guid) == true ? Security.Md5_16ToUpper(asset.id.ToString()).ToString() : asset.guid;
                // 生成二维码的内容


                string param = $"{{\"scene\":\"CaliAssets\",\"parameter\":\"AssetId={asset.Id}&AssetsNo=\"{asset.AssetNumber}\"&SN=\"{asset.AssetStockNumber}\"}}";
                QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
                // QRCodeGenerator.ECCLevel:纠错能力，Q级:可纠错25%的数码错字
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(param, QRCodeGenerator.ECCLevel.Q);
                QRCode qrcode = new QRCode(qrCodeData);

                var pngByte = System.IO.File.ReadAllBytes(imgFilePath);
                MemoryStream stream = new MemoryStream(pngByte);
                var icon = new Bitmap(stream);
                Bitmap qrCodeImage = qrcode.GetGraphic(12, Color.Black, Color.White, icon, 36, 4, false);
                //重画图片（图片加高）
                Bitmap newMap = new Bitmap(qrCodeImage.Width + 130, qrCodeImage.Height + 130);
                Graphics gp = Graphics.FromImage(newMap);
                gp.Clear(Color.White);
                gp.DrawImage(newMap, newMap.Width, newMap.Height);
                gp.DrawImage(qrCodeImage, 65, 65);
                //图片处理，加上序列号
                WatermarkText waterText = new WatermarkText();
                waterText.Text = "AssetsNo:" + asset.AssetNumber;
                waterText.FontFamily = "微软雅黑";
                waterText.FontColor = "#000000";
                waterText.FontSize = 42;
                //获得水印的像素宽度
                SizeF size = gp.MeasureString(waterText.Text, new Font("微软雅黑", 42, GraphicsUnit.Pixel));
                waterText.LocationX = (newMap.Width / 2) - (int)(size.Width / 2);
                waterText.LocationY = qrCodeImage.Height + 65;
                var newImage = ImageCore.Watermark(newMap, waterText, FontStyle.Bold);

                System.Drawing.Image newImage2 = newImage;
                string title = "新威智能扫码管理";
                var chars = title.ToArray();
                int gap = 0;//字间距
                            //获得水印的像素宽度

                SizeF size3 = gp.MeasureString(chars[0].ToString(), new Font("微软雅黑", 42, GraphicsUnit.Pixel));
                int startX = newMap.Width / 2 - (int)(((size3.Width * chars.Length) + ((chars.Length - 1) * gap)) / 2);
                int count = 0;

                foreach (var item in chars)
                {
                    WatermarkText waterText22 = new WatermarkText();
                    waterText22.Text = item.ToString();
                    waterText22.FontFamily = "微软雅黑";
                    waterText22.FontColor = "#000000";
                    waterText22.FontSize = 42;
                    waterText22.LocationX = startX + ((int)size3.Width + gap) * count;
                    waterText22.LocationY = 3;
                    newImage2 = ImageCore.Watermark(newImage2, waterText22, FontStyle.Bold);
                    count++;
                }
                //将Image转换成流数据，并保存为byte[] 
                MemoryStream mstream = new MemoryStream();
                newImage2.Save(mstream, ImageFormat.Jpeg);
                var bytes = mstream.ToArray();
                streamList.Add(asset.AssetNumber, mstream);
            }
            var the_zip = ZipHelper.PackageManyZip(streamList);

            var result = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(the_zip.ToArray())
            };
            result.Content.Headers.ContentDisposition =
                new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment")
                {
                    FileName = "QrCodes.zip"
                };
            result.Content.Headers.ContentType =
                new MediaTypeHeaderValue("application/zip");
            return (HttpResponseMessage)result;
        }

    }
}
