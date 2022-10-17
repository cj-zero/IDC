using IDC.Repository.Core;
using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Nwcali
{
    [ConnectionString("Nsap4NwcaliDbContext")]
    public partial class LaboratoryAssetCategory : BaseEntity<int>
    {
        public LaboratoryAssetCategory()
        {
            this.CategoryNumber = string.Empty;
            this.CategoryType = string.Empty;
        }


        /// <summary>
        /// 资产ID
        /// </summary>
        public int? LaboratoryAssetId { get; set; }
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

        public override void GenerateDefaultKeyVal()
        {

        }

        public override bool KeyIsNull()
        {
            return Id == 0;
        }
    }
}
