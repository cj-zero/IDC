using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Image
{
    /// <summary>
    /// 核心图片处理
    /// </summary>
    public static class ImageCore
    {
        #region 裁剪缩放

        /// <summary>
        /// 裁剪缩放
        /// 按模版比例最大范围裁剪图片并缩放至模版尺寸
        /// </summary>
        /// <param name="fromFile">原图Stream对象</param>
        /// <param name="savePath">缩略图存放地址</param>
        /// <param name="targetWidth">目标宽度</param>
        /// <param name="targetHeight">目标高度</param>
        /// <param name="waterText">水印文字</param>
        /// <param name="waterImage">水印图片</param>
        /// <param name="quality">目标质量(0-100)</param>
        public static void Cut(System.IO.Stream fromFile, string savePath, int targetWidth, int targetHeight,
            WatermarkText waterText, WatermarkImage waterImage, int quality)
        {
            //创建目录
            string dir = Path.GetDirectoryName(savePath);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            //从文件获取原始图片，并使用流中嵌入的颜色管理信息
            using (System.Drawing.Image initImage = System.Drawing.Image.FromStream(fromFile, true))
            {
                //模板的宽和高均大于原图，不作处理，直接保存原图
                if (targetWidth >= initImage.Width && targetHeight >= initImage.Height)
                {
                    //文字水印
                    Watermark(initImage, waterText);

                    //图片水印
                    Watermark(initImage, waterImage);

                    //保存
                    initImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                {
                    #region 裁剪定位

                    //原图片的宽高比例
                    double fromRate = (double)initImage.Width / initImage.Height;
                    //目标的宽高比例
                    double toRate = (double)targetWidth / targetHeight;

                    //原图裁剪定位
                    Rectangle fromR = new Rectangle(0, 0, 0, 0);
                    //目标定位
                    Rectangle toR = new Rectangle(0, 0, targetWidth, targetHeight);

                    //以原图宽为标准进行裁剪
                    if (toRate >= fromRate)
                    {
                        //裁剪源定位
                        fromR.X = 0;
                        fromR.Width = initImage.Width;
                        fromR.Y = (int)System.Math.Floor((initImage.Height - initImage.Width / toRate) / 2);
                        fromR.Height = (int)System.Math.Floor(initImage.Width / toRate);
                    }
                    //以原图高为标准进行裁剪
                    else
                    {
                        fromR.X = (int)System.Math.Floor((initImage.Width - initImage.Height * toRate) / 2);
                        fromR.Width = (int)System.Math.Floor(initImage.Height * toRate);
                        fromR.Y = 0;
                        fromR.Height = initImage.Height;
                    }

                    #endregion

                    using (System.Drawing.Bitmap pickedImage = new System.Drawing.Bitmap(toR.Width, toR.Height))
                    {
                        using (System.Drawing.Graphics pickedG = System.Drawing.Graphics.FromImage(pickedImage))
                        {
                            //设置质量
                            pickedG.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            pickedG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                            //设置背景色
                            pickedG.Clear(Color.White);
                            //裁剪
                            pickedG.DrawImage(initImage, toR, fromR, System.Drawing.GraphicsUnit.Pixel);

                            //文字水印
                            Watermark(pickedImage, waterText);

                            //图片水印
                            Watermark(pickedImage, waterImage);

                            //关键质量控制
                            ImageCodecInfo jgpEncoder = getEncoder(ImageFormat.Jpeg);
                            // Create an Encoder object based on the GUID
                            // for the Quality parameter category.
                            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                            // Create an EncoderParameters object.
                            // An EncoderParameters object has an array of EncoderParameter
                            // objects. In this case, there is only one
                            // EncoderParameter object in the array.
                            EncoderParameters myEncoderParameters = new EncoderParameters(1);
                            //质量值范围修正
                            quality = ((quality < 0 || quality > 100) ? 100 : quality);
                            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, (long)quality);
                            myEncoderParameters.Param[0] = myEncoderParameter;

                            //保存缩略图
                            pickedImage.Save(savePath, jgpEncoder, myEncoderParameters);

                            //释放资源
                            pickedG.Dispose();
                        }
                        //释放资源
                        pickedImage.Dispose();
                    }
                }
                //释放资源
                initImage.Dispose();
            }
        }

        #endregion

        #region 等比缩放

        /// <summary>
        /// 等比缩放类型
        /// </summary>
        public enum ZoomType
        {
            /// <summary>
            /// 自动
            /// </summary>
            AUTO,

            /// <summary>
            /// 宽
            /// </summary>
            WIDTH,

            /// <summary>
            /// 高
            /// </summary>
            HEIGHT
        }

        /// <summary>
        /// 图片等比缩放
        /// 吴剑 2014-11-14
        /// </summary>
        /// <param name="fromFile">原图Stream对象</param>
        /// <param name="savePath">缩略图存放地址</param>
        /// <param name="targetWidth">目标宽度</param>
        /// <param name="targetHeight">目标高度</param>
        /// <param name="waterText">水印文字</param>
        /// <param name="waterImage">水印图片</param>
        /// <param name="zoomType">缩放类型</param>
        /// <param name="quality">目标质量(0-100)</param>
        public static void Zoom(System.IO.Stream fromFile, string savePath, int targetWidth, int targetHeight,
            WatermarkText waterText, WatermarkImage waterImage, ZoomType zoomType, int quality)
        {
            //创建目录
            string dir = Path.GetDirectoryName(savePath);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            //原始图片（获取原始图片创建对象，并使用流中嵌入的颜色管理信息）
            using (System.Drawing.Image initImage = System.Drawing.Image.FromStream(fromFile, true))
            {
                //模板的宽和高均大于原图，不作处理，直接保存原图
                if (targetWidth >= initImage.Width && targetHeight >= initImage.Height)
                {
                    //文字水印
                    Watermark(initImage, waterText);

                    //图片水印
                    Watermark(initImage, waterImage);

                    //保存
                    initImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                {
                    #region 缩略图宽、高计算

                    double newWidth = initImage.Width;
                    double newHeight = initImage.Height;

                    switch (zoomType)
                    {
                        case ZoomType.WIDTH:
                            //如果宽大于模版
                            if (initImage.Width > targetWidth)
                            {
                                newWidth = targetWidth;
                                newHeight = initImage.Height * ((double)targetWidth / initImage.Width);
                            }
                            break;
                        case ZoomType.HEIGHT:
                            //如果高大于模版
                            if (initImage.Height > targetHeight)
                            {
                                newHeight = targetHeight;
                                newWidth = initImage.Width * ((double)targetHeight / initImage.Height);
                            }
                            break;
                        case ZoomType.AUTO:
                            //宽大于高或宽等于高（横图或正方）
                            if (initImage.Width >= initImage.Height)
                            {
                                //如果宽大于模版
                                if (initImage.Width > targetWidth)
                                {
                                    //宽按模版，高按比例缩放
                                    newWidth = targetWidth;
                                    newHeight = initImage.Height * ((double)targetWidth / initImage.Width);
                                }
                            }
                            //高大于宽（竖图）
                            else
                            {
                                //如果高大于模版
                                if (initImage.Height > targetHeight)
                                {
                                    //高按模版，宽按比例缩放
                                    newHeight = targetHeight;
                                    newWidth = initImage.Width * ((double)targetHeight / initImage.Height);
                                }
                            }
                            break;
                    }

                    #endregion

                    //新建一个bmp图片
                    using (System.Drawing.Bitmap newImage = new System.Drawing.Bitmap((int)newWidth, (int)newHeight))
                    {
                        //新建一个画板
                        using (System.Drawing.Graphics newG = System.Drawing.Graphics.FromImage(newImage))
                        {
                            //设置质量
                            newG.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            newG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                            //设置置背景色
                            newG.Clear(Color.White);
                            //画图
                            newG.DrawImage(initImage, new System.Drawing.Rectangle(0, 0, newImage.Width, newImage.Height), new System.Drawing.Rectangle(0, 0, initImage.Width, initImage.Height), System.Drawing.GraphicsUnit.Pixel);

                            //文字水印
                            Watermark(newImage, waterText);

                            //图片水印
                            Watermark(newImage, waterImage);

                            //关键质量控制
                            ImageCodecInfo jgpEncoder = getEncoder(ImageFormat.Jpeg);
                            // Create an Encoder object based on the GUID
                            // for the Quality parameter category.
                            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                            // Create an EncoderParameters object.
                            // An EncoderParameters object has an array of EncoderParameter
                            // objects. In this case, there is only one
                            // EncoderParameter object in the array.
                            EncoderParameters myEncoderParameters = new EncoderParameters(1);
                            //质量值范围修正
                            quality = ((quality < 0 || quality > 100) ? 100 : quality);
                            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, (long)quality);
                            myEncoderParameters.Param[0] = myEncoderParameter;

                            //保存缩略图
                            newImage.Save(savePath, jgpEncoder, myEncoderParameters);

                            //释放资源
                            newG.Dispose();
                        }

                        //释放资源
                        newImage.Dispose();
                    }
                }

                //释放资源
                initImage.Dispose();
            }
        }

        #endregion

        #region 水印

        /// <summary>
        /// 文字水印
        /// </summary>
        /// <param name="img">原始图片</param>
        /// <param name="wt">文字水印对象</param>
        /// <returns></returns>
        public static System.Drawing.Image Watermark(System.Drawing.Image img, WatermarkText wt)
        {
            if (wt != null)
            {
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(img))
                {
                    System.Drawing.Font font = new System.Drawing.Font(wt.FontFamily, wt.FontSize * 72 / g.DpiX, wt.FontWeight);
                    System.Drawing.Brush brush = new SolidBrush(ColorTranslator.FromHtml(wt.FontColor));
                    g.DrawString(wt.Text, font, brush, wt.LocationX, wt.LocationY);
                    g.Dispose();
                }
            }

            return img;
        }

        public static System.Drawing.Image Watermark(System.Drawing.Image img, WatermarkText wt, FontStyle style)
        {
            if (wt != null)
            {
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(img))
                {
                    System.Drawing.Font font = new System.Drawing.Font(wt.FontFamily, wt.FontSize * 72 / g.DpiX, style);
                    System.Drawing.Brush brush = new SolidBrush(ColorTranslator.FromHtml(wt.FontColor));
                    g.DrawString(wt.Text, font, brush, wt.LocationX, wt.LocationY);
                    g.Dispose();
                }
            }

            return img;
        }

        /// <summary>
        /// 文字水印
        /// </summary>
        /// <param name="img">原始图片</param>
        /// <param name="wt">文字水印对象</param>
        /// <returns></returns>
        public static System.Drawing.Image WatermarkNew(System.Drawing.Image img, WatermarkText wt)
        {
            if (wt != null)
            {
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(img))
                {
                    System.Drawing.Font font = new System.Drawing.Font(wt.Font, wt.FontWeight);
                    System.Drawing.Brush brush = new SolidBrush(ColorTranslator.FromHtml(wt.FontColor));
                    g.DrawString(wt.Text, font, brush, wt.LocationX, wt.LocationY);
                    g.Dispose();
                }
            }

            return img;
        }

        /// <summary>
        /// 图片水印
        /// </summary>
        /// <remarks>吴剑 2013-10-12</remarks>
        /// <param name="img">原始图片</param>
        /// <param name="wi">图片水印对象</param>
        /// <returns></returns>
        public static System.Drawing.Image Watermark(System.Drawing.Image img, WatermarkImage wi, int x = 0, int y = 0)
        {
            if (wi != null && wi.ImagePath != "" && File.Exists(wi.ImagePath))
            {
                //获取水印图片
                using (System.Drawing.Image wImage = System.Drawing.Image.FromFile(wi.ImagePath))
                {
                    //水印绘制条件：原始图片宽高均大于或等于水印图片
                    if (img.Width >= wImage.Width && img.Height >= wImage.Height)
                    {
                        //开始绘制
                        using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(img))
                        {
                            //透明属性
                            ImageAttributes imgAttributes = new ImageAttributes();
                            ColorMap colorMap = new ColorMap();
                            colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);
                            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
                            ColorMap[] remapTable = { colorMap };
                            imgAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);

                            float[][] colorMatrixElements = {
                                   new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},
                                   new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},
                                   new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},
                                   new float[] {0.0f,  0.0f,  0.0f,  wi.Alpha, 0.0f},//透明度
                                   new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}
                                };

                            ColorMatrix wmColorMatrix = new ColorMatrix(colorMatrixElements);
                            imgAttributes.SetColorMatrix(wmColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            if (x == 0 && y == 0)
                            {
                                //右下角
                                //g.DrawImage(
                                //    wImage, 
                                //    new Rectangle(img.Width - wImage.Width, img.Height - wImage.Height, wImage.Width, wImage.Height), 
                                //    0, 0, wImage.Width, wImage.Height, GraphicsUnit.Pixel, imgAttributes);

                                //左下角
                                //g.DrawImage(
                                //    wImage,
                                //    new Rectangle(0, img.Height - wImage.Height, wImage.Width, wImage.Height),
                                //    0, 0, wImage.Width, wImage.Height, GraphicsUnit.Pixel, imgAttributes);

                                //水平垂直居中
                                g.DrawImage(
                                    wImage, //水印图片
                                    new Rectangle(
                                        (img.Width - wImage.Width) / 2,
                                        (img.Height - wImage.Height) / 2,
                                        wImage.Width,
                                        wImage.Height),
                                    0, 0, wImage.Width, wImage.Height, GraphicsUnit.Pixel, imgAttributes);

                            }
                            else
                            {
                                //指定位置
                                g.DrawImage(
                                    wImage, //水印图片
                                    new Rectangle(
                                       x,
                                        y,
                                        wImage.Width,
                                        wImage.Height),
                                    0, 0, wImage.Width, wImage.Height, GraphicsUnit.Pixel, imgAttributes);
                            }
                            g.Dispose();
                        }
                    }

                    wImage.Dispose();
                }
            }

            return img;
        }

        #endregion

        #region 其它

        private static ImageCodecInfo getEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        #endregion

        //图片处理为圆角
        public static System.Drawing.Image DrawTransparentRoundCornerImage(System.Drawing.Image image, int cornerRadius)
        {
            Bitmap bm = new Bitmap(image.Width, image.Height);
            Graphics g = Graphics.FromImage(bm);
            g.FillRectangle(Brushes.Transparent, new Rectangle(0, 0, image.Width, image.Height));

            using (System.Drawing.Drawing2D.GraphicsPath path = CreateRoundedRectanglePath(new Rectangle(0, 0, image.Width, image.Height), cornerRadius))
            {
                g.SetClip(path);
            }

            g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            g.Dispose();

            return bm;
        }
        //设置图片四个边角弧度
        private static System.Drawing.Drawing2D.GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            System.Drawing.Drawing2D.GraphicsPath roundedRect = new System.Drawing.Drawing2D.GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }
        public static System.Drawing.Image CutEllipse(System.Drawing.Image img, Rectangle rec, Size size)
        {
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (TextureBrush br = new TextureBrush(img, System.Drawing.Drawing2D.WrapMode.Clamp, rec))
                {
                    br.ScaleTransform(bitmap.Width / (float)rec.Width, bitmap.Height / (float)rec.Height);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.FillEllipse(br, new Rectangle(Point.Empty, size));
                }
            }
            return bitmap;
        }
    }
}
