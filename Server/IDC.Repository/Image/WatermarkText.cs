using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Image
{
    /// <summary>
    /// 文字水印
    /// </summary>
    public class WatermarkText
    {
        public WatermarkText() { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="text">文本内容</param>
        /// <param name="fontFamily">字体名称，如：黑体</param>
        /// <param name="fontColor">字体颜色，如：#FFFFFF</param>
        /// <param name="fontSize">字体大小（像素）</param>
        /// <param name="locationX">左上角X坐标</param>
        /// <param name="locationY">左上角Y坐标</param>
        public WatermarkText(string text, string fontFamily, string fontColor, int fontSize, int locationX, int locationY, FontStyle fontWeight, Font font)
        {
            this.Text = text;
            this.FontFamily = fontFamily;
            this.FontColor = fontColor;
            this.FontSize = fontSize;
            this.LocationX = locationX;
            this.LocationY = locationY;
            this.FontWeight = fontWeight;
            this.Font = font;
        }

        /// <summary>
        /// 文本内容
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 字体名称，如：黑体
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// 字体颜色，如：#FFFFFF
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// 字体大小（像素）
        /// </summary>
        public int FontSize { get; set; }

        /// <summary>
        /// 左上角X坐标
        /// </summary>
        public int LocationX { get; set; }

        /// <summary>
        /// 左上角Y坐标
        /// </summary>
        public int LocationY { get; set; }

        public FontStyle FontWeight { get; set; }

        public Font Font { get; set; }
    }
}
