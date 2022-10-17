using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali.Request
{
    public partial class AddOrUpdateassetcategoryReq
    {
        /// <summary>
        /// ID
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// 资产ID
        /// </summary>
        public int? AssetId { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public string CategoryNumber { get; set; }
        /// <summary>
        /// 阻值
        /// </summary>
        public decimal? CategoryOhms { get; set; }
        /// <summary>
        /// 不确定度
        /// </summary>
        public decimal? CategoryNondeterminacy { get; set; }
        /// <summary>
        /// 不确定类型
        /// </summary>
        public string CategoryType { get; set; }
        /// <summary>
        /// 包含因子K
        /// </summary>
        public decimal? CategoryBHYZ { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? CategoryAort { get; set; }

        //todo:添加自己的请求字段
    }
}
