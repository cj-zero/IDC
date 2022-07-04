using IDC.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDC.Repository.Entities.Nwcali
{
    [ConnectionString("Nsap4NwcaliDbContext", "Nsap4NwcaliDbContext")]
    public class DeviceCheckTask
    {
        public int? Id { get; set; }
        public string EdgeGuid { get; set; }
        /// <summary>
        /// 上位机guid
        /// </summary>
        public string SrvGuid { get; set; }
        /// <summary>
        /// 中位机编号
        /// </summary>
        public int DevUid { get; set; }
        /// <summary>
        /// 下位机单元id
        /// </summary>
        public int UnitId { get; set; }
        public int ChlId { get; set; }
        public long TestId { get; set; }
        public DateTime CreateTime { get; set; }
        public int ErrCount { get; set; }
        public string TaskId { get; set; }
        /// <summary>
        /// 任务状态（0:准备;1:检测中;2:检测完成）
        /// </summary>
        public sbyte TaskStatus { get; set; }
        public string TaskContent { get; set; }
        public int TaskErrCount { get; set; }
    }
}
