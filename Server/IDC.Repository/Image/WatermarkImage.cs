using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Image
{
    /// <summary>
    /// 图片水印
    /// </summary>
    public class WatermarkImage
    {
        public WatermarkImage() { }

        public WatermarkImage(string imagePath, float alpha = 0.5f)
        {
            this.ImagePath = imagePath;
            this.Alpha = alpha;
        }

        /// <summary>
        /// 水印图片路径
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// 透明度(0.00-1.00)
        /// </summary>
        public float Alpha { get; set; }
    }
}
