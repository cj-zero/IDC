using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali.Request
{
    public class AssetsCategoryReq
    {
        public string customer_id { get; set; }
        public int passport_id { get; set; }
    }
    public class AssetsDelete : AssetsCategoryReq
    {
        /// <summary>
        /// 资产id
        /// </summary>
        public int assets_id { get; set; }
        /// <summary>
        /// 实验室id
        /// </summary>
        public int room_id { get; set; }
    }

    public class AddCategory : AssetsCategoryReq
    {
        public int parent_id { get; set; }
        public string name { get; set; }
    }

    public class CategorySpecs : AssetsCategoryReq
    {
        /// <summary>
        /// 资产类型ID
        /// </summary>
        public int category_id { get; set; }
        /// <summary>
        ///  属性ID list
        /// </summary>
        public List<int> specIds { get; set; }
    }
    public class DeleteSpecs : AssetsCategoryReq
    {
        /// <summary>
        ///  属性ID list
        /// </summary>
        public List<int> specIds { get; set; }

    }
    public class EditSpec : AssetsCategoryReq
    {
        /// <summary>
        /// 编辑属性需要 属性id
        /// </summary>
        public int spec_id { get; set; }

        public string spec_name { get; set; }
    }
}
