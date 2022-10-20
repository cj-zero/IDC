using IDC.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Nwcali
{
    /// <summary>
    /// 组合资产映射表
    /// </summary>
    public class PortfolioAssetsMap : BaseEntity<int>
    {
        /// <summary>
        /// 组合表id
        /// </summary>
        public int PortfolioId { get; set; }

        /// <summary>
        /// 资产表id
        /// </summary>
        public int AssetId { get; set; }

        /// <summary>
        /// 资产类型 1=实验室资产  2=普通资产
        /// </summary>
        public int SourceType { get; set; }

        /// <summary>
        ///  配件类型 1=固定配件   2=临时配件
        /// </summary>
        public int PartsType { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int Sort { get; set; }
        public override void GenerateDefaultKeyVal()
        {

        }

        public override bool KeyIsNull()
        {
            return Id == 0;
        }
    }
}
