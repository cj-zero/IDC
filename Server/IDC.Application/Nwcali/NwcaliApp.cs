using IDC.Application.Basics;
using IDC.Application.SSO;
using IDC.Infrastructure.Returned;
using IDC.Repository.Dapper;
using OpenAuth.Repository.Domain;
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
                var sql = $"select * from machineinfo where Guid='{guid}' and `Status`=1";
                var query = (await _repositoryBase.FindAsync<MachineInfo>(sql, null)).ToList();
                if (query != null && query.Count > 0)
                {
                    result.Data = true;
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
