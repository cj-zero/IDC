using IDC.Application.Basics;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.Nwcali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.Nwcali
{
    public class NwcaliApp : BaseApp
    {
        public NwcaliApp(IRepositoryBase repositoryBase, IAuth auth) : base(auth, repositoryBase)
        {
            
        }

        /// <summary>
        /// 是否通过烤机
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public async Task<TableData> IsPass(string guid)
        {
            TableData result = new TableData();
            result.Data = false;
            try
            {
                //下位机最新的烤机环境下烤机记录
                var sql = $"select EdgeGuid,SrvGuid,DevUid,LowGuid from devicetestlog where LowGuid='{guid}' order by id desc limit 1";
                var query = (await _repositoryBase.FindAsync<DeviceTestLog>(sql, null)).Select(c=>new  {c.EdgeGuid,c.SrvGuid,c.DevUid,c.LowGuid }).FirstOrDefault();
                if (query != null)
                {
                    //通道烤机结果
                    var channel = $"select Status,TaskStatus,TaskErrCount from devicetestlog where EdgeGuid='{query.EdgeGuid}' and SrvGuid='{query.SrvGuid}' and DevUid={query.DevUid} and LowGuid='{query.LowGuid}'";
                    var channelQuery = (await _repositoryBase.FindAsync<DeviceTestLog>(channel, null)).Select(c => new { c.Status, c.TaskStatus, c.TaskErrCount }).ToList();
                    //状态为已完成，检测结果为完成，错误数量为0
                    var res = channelQuery.All(c => c.Status == -1 && c.TaskStatus == 2 && c.TaskErrCount == 0);
                    result.Data = res;
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return result;
        }
    }
}
