using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali.Request
{
    public partial class AddOrUpdateassetoperationReq
    {

        /// <summary>
        /// 操作ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 资产ID
        /// </summary>
        public int? AssetId { get; set; }
        /// <summary>
        /// 送检ID
        /// </summary>
        public string InspectId { get; set; }
        /// <summary>
        /// 操作内容
        /// </summary>
        public string OperationContent { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public System.DateTime? OperationCreateTime { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string OperationUser { get; set; }

        //todo:添加自己的请求字段
    }
}
