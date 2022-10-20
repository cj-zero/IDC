using IDC.Repository.Core;
using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Entities.Nwcali
{
    [ConnectionString("Nsap4NwcaliDbContext")]
    public  class LaboratoryAsset : BaseEntity<int>
    {

        public LaboratoryAsset()
        {
            this.AssetStatus = string.Empty;
            this.AssetCategory = string.Empty;
            this.OrgName = string.Empty;
            this.AssetType = string.Empty;
            this.AssetHolder = string.Empty;
            this.AssetStockNumber = string.Empty;
            this.AssetAdmin = string.Empty;
            this.AssetNumber = string.Empty;
            this.AssetFactory = string.Empty;
            this.AssetInspectType = string.Empty;
            this.AssetInspectWay = string.Empty;
            this.AssetStartDate = DateTime.Now;
            this.AssetCalibrationCertificate = string.Empty;
            this.AssetEndDate = DateTime.Now;
            this.AssetInspectDataOne = string.Empty;
            this.AssetInspectDataTwo = string.Empty;
            this.AssetTCF = string.Empty;
            this.AssetDescribe = string.Empty;
            this.AssetRemarks = string.Empty;
            this.AssetImage = string.Empty;
            this.AssetCreateTime = DateTime.Now;
            this.AssetCreateUser = string.Empty;
        }
        /// <summary>
        /// 状态
        /// </summary>
        public string AssetStatus { get; set; }
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


        public  List<LaboratoryAssetCategory> LaboratoryAssetCategory { get; set; }

        /// <summary>
        /// 送检记录
        /// </summary>
        public  List<LaboratoryAssetInspect> LaboratoryAssetInspect { get; set; }

        /// <summary>
        /// 操作记录
        /// </summary>
        public  List<LaboratoryAssetOperation> LaboratoryAssetOperation { get; set; }


        public override void GenerateDefaultKeyVal()
        {

        }

        public override bool KeyIsNull()
        {
            return Id == 0;
        }

    }
}
