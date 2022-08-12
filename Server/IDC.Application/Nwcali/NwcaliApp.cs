using IDC.Application.Basics;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using IDC.Repository.Entities.Nwcali;
using Infrastructure;
using Newtonsoft.Json.Linq;
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
            //result.Data = false;
            #region MyRegion
            //var url = "https://analytics.neware.com.cn/";
            //HttpHelper httpHelper = new HttpHelper(url);
            //try
            //{
            //    //下位机最新的烤机环境下烤机记录
            //    var sql = $"select EdgeGuid,SrvGuid,DevUid,LowGuid,UnitId from devicetestlog where LowGuid='{guid}' order by id desc limit 1";
            //    var query = (await _repositoryBase.FindAsync<DeviceTestLog>(sql, null)).Select(c => new { c.EdgeGuid, c.SrvGuid, c.DevUid, c.LowGuid, c.UnitId }).FirstOrDefault();
            //    if (query != null)
            //    {
            //        //烤机通道
            //        var channel = $"select EdgeGuid,SrvGuid,DevUid,LowGuid,UnitId,ChlId,TestId from devicetestlog where EdgeGuid='{query.EdgeGuid}' and SrvGuid='{query.SrvGuid}' and DevUid={query.DevUid} and UnitId={query.UnitId}";
            //        var channelQuery = (await _repositoryBase.FindAsync<DeviceTestLog>(channel, null)).Select(c => new { c.EdgeGuid, c.SrvGuid, c.DevUid, c.LowGuid, c.UnitId, c.ChlId, c.TestId }).ToList();
            //        //通道最新测试ID
            //        channelQuery = channelQuery.GroupBy(c => c.ChlId).Select(c => c.OrderByDescending(o => o.TestId).First()).ToList();
            //        var channelCount = 0;
            //        foreach (var item in channelQuery)
            //        {
            //            //获取每个通道测试任务id
            //            var checktask = $"select EdgeGuid,SrvGuid,DevUid,UnitId,ChlId,TestId,TaskId from devicechecktask where EdgeGuid='{item.EdgeGuid}' and SrvGuid='{item.SrvGuid}' and DevUid={item.DevUid} and UnitId={item.UnitId} and ChlId={item.ChlId} and TestId={item.TestId}";
            //            var checktaskQuery = (await _repositoryBase.FindAsync<DeviceCheckTask>(checktask, null)).Select(c => c.TaskId).FirstOrDefault();
            //            if (!string.IsNullOrWhiteSpace(checktaskQuery))
            //            {
            //                var taskurl = $"api/DataCheck/TaskResult?id={checktaskQuery}"; 
            //                Dictionary<string, string> dic = null;
            //                //获取通道烤机结果
            //                var taskResult = httpHelper.Get(dic, taskurl);
            //                JObject resObj = JObject.Parse(taskResult);
            //                if (resObj["status"] == null || resObj["status"].ToString() != "200")
            //                {
            //                    continue;
            //                }
            //                if (resObj["data"] != null)
            //                {
            //                    int.TryParse(resObj["data"]["ErrCount"].ToString(), out int errCount);
            //                    sbyte.TryParse(resObj["data"]["Status"].ToString(), out sbyte taskStatus);
            //                    if (errCount == 0 && taskStatus == 2)
            //                        channelCount++;
            //                }
            //            }
            //            else
            //            {
            //                result.Message = "烤机任务ID尚未创建。";
            //                return result;
            //            }
            //        }
            //        ///烤机通道通过数=总通道数
            //        if (channelCount == channelQuery.Count)
            //            result.Data = true;
            //    }
            //}
            //catch (Exception e)
            //{
            //    throw;
            //}
            #endregion
            var res = await BakingMachine(guid);
            result.Data = res.Result;
            result.Message = res.Message;
            return result;
        }

        /// <summary>
        /// 是否通过校准
        /// </summary>
        /// <param name="wo"></param>
        /// <returns></returns>
        public async Task<TableData> CheckCalibration(string wo)
        {
            TableData result = new TableData();
            result.Data = false;
            //wo最新的烤机环境下烤机记录
            var sql = $"select EdgeGuid,SrvGuid,DevUid,LowGuid,UnitId from devicetestlog where GeneratorCode='{wo}' order by id desc limit 1";
            var query = (await _repositoryBase.FindAsync<DeviceTestLog>(sql, null)).Select(c => new { c.EdgeGuid, c.SrvGuid, c.DevUid, c.LowGuid, c.UnitId }).FirstOrDefault();
            if (query != null)
            {
                //最新环境下 最新通道测试记录
                var guidSql = $@"select LowGuid from devicetestlog where id in(
                                select MAX(Id) id from devicetestlog where EdgeGuid='{query.EdgeGuid}' and SrvGuid='{query.SrvGuid}' and DevUid={query.DevUid} AND GeneratorCode='{wo}'
                                group by EdgeGuid,SrvGuid,DevUid,UnitId,ChlId)
                                group by LowGuid";
                var guidList = (await _repositoryBase.FindAsync<DeviceTestLog>(sql, null)).Select(c => c.LowGuid).ToList();
                if (guidList.Count > 0)
                {
                    var guid = string.Join("','", guidList);
                    var machineSql = $"SELECT * from machineinfo where Guid in ('{guid}')";
                    var machine = (await _repositoryBase.FindAsync<MachineInfo>(machineSql, null)).ToList();
                    if (machine.Count > 0)
                    {
                        //下位机数量是否等于下位机校准证书数量
                        if (guidList.Count == machine.Count)
                        {
                            result.Data = true;
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// GUID是否和烤机绑定的数据一致
        /// </summary>
        /// <param name="wo"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        public async Task<TableData> CheckBinding(string wo,string guid)
        {
            TableData result = new TableData();
            CheckResp bind = new CheckResp() { Result = false, Message = "GUID不属于订单WO" };
            CheckResp kaoji = new CheckResp() { Result = false };
            if (wo.StartsWith("WO"))
            {
                //wo最新的烤机环境下烤机记录
                var sql = $"select EdgeGuid,SrvGuid,DevUid,LowGuid,UnitId from devicetestlog where GeneratorCode='{wo}' order by id desc limit 1";
                var query = (await _repositoryBase.FindAsync<DeviceTestLog>(sql, null)).Select(c => new { c.EdgeGuid, c.SrvGuid, c.DevUid, c.LowGuid, c.UnitId }).FirstOrDefault();
                if (query != null)
                {
                    //最新环境下 最新通道测试记录
                    var guidSql = $@"select LowGuid from devicetestlog where id in(
                                select MAX(Id) id from devicetestlog where EdgeGuid='{query.EdgeGuid}' and SrvGuid='{query.SrvGuid}' and DevUid={query.DevUid} AND GeneratorCode='{wo}'
                                group by EdgeGuid,SrvGuid,DevUid,UnitId,ChlId) 
                                group by LowGuid";
                    var guidList = (await _repositoryBase.FindAsync<DeviceTestLog>(guidSql, null)).Select(c => c.LowGuid).ToList();
                    if (guidList.Count > 0)
                    {
                        //wo包含此guid
                        if (guidList.Contains(guid))
                        {
                            bind.Result = true;
                            bind.Message = "ok";
                            kaoji = await BakingMachine(guid);
                        }
                    }
                }
                else
                {
                    bind.Message = "WO暂无绑定记录";
                }
            }
            else
            {
                bind = new CheckResp() { Result = true };
                kaoji = new CheckResp() { Result = true };
            }
            result.Data = new { Binding = bind, BakingMachine = kaoji };
            return result;
        }

        /// <summary>
        /// 烤机验证
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public async Task<CheckResp> BakingMachine(string guid)
        {
            CheckResp checkResp = new CheckResp() { Result = false, Message = "烤机暂未通过。" };
            var url = "https://analytics.neware.com.cn/";
            HttpHelper httpHelper = new HttpHelper(url);
            try
            {
                //下位机最新的烤机环境下烤机记录
                var sql = $"select EdgeGuid,SrvGuid,DevUid,LowGuid,UnitId from devicetestlog where LowGuid='{guid}' order by id desc limit 1";
                var query = (await _repositoryBase.FindAsync<DeviceTestLog>(sql, null)).Select(c => new { c.EdgeGuid, c.SrvGuid, c.DevUid, c.LowGuid, c.UnitId }).FirstOrDefault();
                if (query != null)
                {
                    //烤机通道
                    var channel = $"select EdgeGuid,SrvGuid,DevUid,LowGuid,UnitId,ChlId,TestId from devicetestlog where EdgeGuid='{query.EdgeGuid}' and SrvGuid='{query.SrvGuid}' and DevUid={query.DevUid} and UnitId={query.UnitId}";
                    var channelQuery = (await _repositoryBase.FindAsync<DeviceTestLog>(channel, null)).Select(c => new { c.EdgeGuid, c.SrvGuid, c.DevUid, c.LowGuid, c.UnitId, c.ChlId, c.TestId }).ToList();
                    //通道最新测试ID
                    channelQuery = channelQuery.GroupBy(c => c.ChlId).Select(c => c.OrderByDescending(o => o.TestId).First()).ToList();
                    var channelCount = 0;
                    foreach (var item in channelQuery)
                    {
                        //获取每个通道测试任务id
                        var checktask = $"select EdgeGuid,SrvGuid,DevUid,UnitId,ChlId,TestId,TaskId from devicechecktask where EdgeGuid='{item.EdgeGuid}' and SrvGuid='{item.SrvGuid}' and DevUid={item.DevUid} and UnitId={item.UnitId} and ChlId={item.ChlId} and TestId={item.TestId}";
                        var checktaskQuery = (await _repositoryBase.FindAsync<DeviceCheckTask>(checktask, null)).Select(c => c.TaskId).FirstOrDefault();
                        if (!string.IsNullOrWhiteSpace(checktaskQuery))
                        {
                            var taskurl = $"api/DataCheck/TaskResult?id={checktaskQuery}";
                            Dictionary<string, string> dic = null;
                            //获取通道烤机结果
                            var taskResult = httpHelper.Get(dic, taskurl);
                            JObject resObj = JObject.Parse(taskResult);
                            if (resObj["status"] == null || resObj["status"].ToString() != "200")
                            {
                                continue;
                            }
                            if (resObj["data"] != null)
                            {
                                int.TryParse(resObj["data"]["ErrCount"].ToString(), out int errCount);
                                sbyte.TryParse(resObj["data"]["Status"].ToString(), out sbyte taskStatus);
                                if (errCount == 0 && taskStatus == 2)
                                    channelCount++;
                            }
                        }
                        else
                        {
                            checkResp.Message = "烤机任务ID尚未创建。";
                            return checkResp;
                        }
                    }
                    ///烤机通道通过数=总通道数
                    if (channelCount == channelQuery.Count)
                        checkResp.Result = true; checkResp.Message = "";
                }
            }
            catch (Exception ex)
            {
                checkResp.Message = ex.Message;
            }
            return checkResp;
        }
    }
}
