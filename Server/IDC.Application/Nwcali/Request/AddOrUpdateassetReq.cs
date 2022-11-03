using IDC.Repository.AutoMapper;
using IDC.Repository.Core;
using IDC.Repository.Entities.Nwcali;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali.Request
{
    [AutoMapTo(typeof(LaboratoryAsset))]
    [Table("asset")]
    public partial class AddOrUpdateassetReq
    {

        /// <summary>
        /// 资产ID
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Guid
        /// </summary>
        public string Guid { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string AssetStatus { get; set; }

        /// <summary>
        /// 状态序号
        /// </summary>
        public string AssetSerial { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string AssetCategory { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public string OrgName { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        public string AssetType { get; set; }
        /// <summary>
        /// 持有者
        /// </summary>
        public string AssetHolder { get; set; }
        /// <summary>
        /// 出厂编号S/N
        /// </summary>
        public string AssetStockNumber { get; set; }
        /// <summary>
        /// 管理员
        /// </summary>
        public string AssetAdmin { get; set; }
        /// <summary>
        /// 资产编号
        /// </summary>
        public string AssetNumber { get; set; }
        /// <summary>
        /// 制造厂
        /// </summary>
        public string AssetFactory { get; set; }
        /// <summary>
        /// 送检类型
        /// </summary>
        public string AssetInspectType { get; set; }
        /// <summary>
        /// 送检方式
        /// </summary>
        public string AssetInspectWay { get; set; }
        /// <summary>
        /// 校准日期
        /// </summary>
        public System.DateTime? AssetStartDate { get; set; }
        /// <summary>
        /// 校准证书
        /// </summary>
        public string AssetCalibrationCertificate { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        public System.DateTime? AssetEndDate { get; set; }
        /// <summary>
        /// 校准数据1
        /// </summary>
        public string AssetInspectDataOne { get; set; }
        /// <summary>
        /// 校准数据2
        /// </summary>
        public string AssetInspectDataTwo { get; set; }
        /// <summary>
        /// 技术文件
        /// </summary>
        public string AssetTCF { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string AssetDescribe { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string AssetRemarks { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string AssetImage { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? AssetCreateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string AssetCreateUser { get; set; }
        /// <summary>
        /// 企业ID
        /// </summary>
        public string CustomerId { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int PassPortId { get; set; }


        //todo:添加自己的请求字段
        /// <summary>
        /// 
        /// </summary>
        public virtual List<AddOrUpdateassetcategoryReq> laboratoryAssetCategory { get; set; }
    }
}
