using Dapper;
using IDC.Infrastructure.AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Dapper
{
    public class RepositoryBase : IRepositoryBase
    {
        private readonly IConfiguration _configuration;
        protected IDbConnection connection=null;
        private readonly Dictionary<string,IDbConnection> dbConnections =new Dictionary<string, IDbConnection>();
        public RepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection DbConnection<T>(WriteAndReadEnum writeAndRead =WriteAndReadEnum.Read) where T : class
        {
            var ConstructorArguments = typeof(T).CustomAttributes.Select(c => c.ConstructorArguments).ToList();
            var values = ConstructorArguments?[0]?.Select(c => c.Value)?.ToList();
            var connstring = "";
            if (values != null)
            {
                if (writeAndRead == WriteAndReadEnum.Write)
                {
                    if (dbConnections.TryGetValue(values[0].ToString(), out IDbConnection dbConnection))
                    {
                        return dbConnection;
                    }
                    else
                    {
                        connstring = _configuration.GetConnectionString(values[0].ToString());
                        var databaseType = DatabaseType.MySql;
                        switch (values[2])
                        {
                            case 0:
                                databaseType = DatabaseType.SqlServer;
                                break;
                            case 1:
                                databaseType = DatabaseType.MySql;
                                break;
                            case 2:
                                databaseType = DatabaseType.Npgsql;
                                break;
                            case 3:
                                databaseType = DatabaseType.Oracle;
                                break;
                            case 4:
                                databaseType = DatabaseType.Sqlite;
                                break;
                            default:
                                break;
                        }
                        dbConnection = new ConnectionFactory(databaseType, connstring).CreateConnection();
                        dbConnections.TryAdd(values[0].ToString(), dbConnection);
                        return dbConnection;

                    }
                    
                }
                else
                {
                    if (dbConnections.TryGetValue(values[1].ToString(), out IDbConnection dbConnection))
                    {
                        return dbConnection;
                    }
                    else 
                    {
                        connstring = _configuration.GetConnectionString(values[1].ToString());
                        var databaseType = DatabaseType.MySql;
                        switch (values[2])
                        {
                            case 0:
                                databaseType = DatabaseType.SqlServer;
                                break;
                            case 1:
                                databaseType = DatabaseType.MySql;
                                break;
                            case 2:
                                databaseType = DatabaseType.Npgsql;
                                break;
                            case 3:
                                databaseType = DatabaseType.Oracle;
                                break;
                            case 4:
                                databaseType = DatabaseType.Sqlite;
                                break;
                            default:
                                break;
                        }
                        dbConnection = new ConnectionFactory(databaseType, connstring).CreateConnection();
                        if (Convert.ToInt32(values[2]) != 0)//SqlServer链接不加入集合,解决using释放后链接字符串为空 ConnectionString 属性尚未初始化
                        {
                            dbConnections.TryAdd(values[1].ToString(), dbConnection);
                        }
                        return dbConnection;
                    }
                }
            }
            throw new Exception("当前实体未指向数据库");
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insertSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public T Add<T>(string insertSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return connection.ExecuteScalar<T>(insertSql, param); 
            }
        }

        /// <summary>
        /// 异步新增
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insertSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>

        public async Task<T> AddAsync<T>(string insertSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return await connection.ExecuteScalarAsync<T>(insertSql, param);
            }
        }

        /// <summary>
        /// 批量新增
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insertSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<int> BatchAddAsync<T>(string insertSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return await connection.ExecuteAsync(insertSql, param);
            }  
        }

        /// <summary>
        /// 获取新增成功后的记录
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insertSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>

        public async Task<IDataReader> GetAddAsync<T>(string insertSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return await connection.ExecuteReaderAsync(insertSql, param);
            }  
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="updateSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public int UpDate<T>(string updateSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return connection.Execute(updateSql, param);
            }
        }

        /// <summary>
        /// 异步修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="updateSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<int> UpDateAsync<T>(string updateSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return await connection.ExecuteAsync(updateSql, param);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="deleteSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public int Delete<T>(string deleteSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return connection.Execute(deleteSql, param);
            }  
        }

        /// <summary>
        /// 异步删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="deleteSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync<T>(string deleteSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return await connection.ExecuteAsync(deleteSql, param);
            } 
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="selectSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> Find<T>(string selectSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>()) 
            {
                return connection.Query(selectSql, param);
            } 
        }

        /// <summary>
        /// 异步查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="selectSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<IEnumerable<dynamic>> FindAsync<T>(string selectSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>()) 
            {
                return await connection.QueryAsync(selectSql, param);
            } 
        }

        /// <summary>
        /// 获取单个详情
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="selectSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public dynamic Detail<T>(string selectSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>()) 
            {
                return connection.QueryFirst(selectSql, param);
            }
        }

        /// <summary>
        /// 异步获取单个详情
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="selectSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<dynamic> DetailAsync<T>(string selectSql, object param = null) where T : class
        {
            using (connection = DbConnection<T>()) 
            {
                return await connection.QueryFirstAsync(selectSql, param);
            } 
        }

        /// <summary>
        /// 查询结果,返回实体集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<T> Query<T>(string sql, DynamicParameters parameters) where T : class
        {
            using var _db = DbConnection<T>();
            return _db.Query<T>(sql, parameters);
        }

        /// <summary>
        /// 异步查询结果,返回实体集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Task<IEnumerable<T>> QueryAsync<T>(string sql, DynamicParameters parameters) where T : class
        {
            using var _db = DbConnection<T>();
            return _db.QueryAsync<T>(sql, parameters);
        }

        /// <summary>
        /// 查询返回单个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public T QueryFirst<T>(string sql, DynamicParameters parameters) where T : class
        {
            using var _db = DbConnection<T>();
            return _db.QueryFirstOrDefault<T>(sql, parameters);
        }

        /// <summary>
        /// 异步查询,返回单个实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Task<T> QueryFirstAsync<T>(string sql, DynamicParameters parameters) where T : class
        {
            using var _db = DbConnection<T>();
            return _db.QueryFirstOrDefaultAsync<T>(sql, parameters);
        }

        /// <summary>
        /// 异步查询,返回实体集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="selectSql"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetAsync<T>(string selectSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>())
            {
                return await connection.QueryAsync<T>(selectSql, entity);
            }
        }


        /// <summary>
        /// 事务1 - 全SQL
        /// </summary>
        /// <param name="sqlarr">多条SQL</param>
        /// <param name="param">param</param>
        /// <returns></returns>
        public int ExecuteTransaction<T>(string[] sqlarr) where T : class
        {
            using (connection = DbConnection<T>())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int result = 0;
                        foreach (var sql in sqlarr)
                        {
                            result += connection.Execute(sql, null, transaction);
                        }

                        transaction.Commit();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return 0;
                    }
                }
            }
        }
        /// <summary>
        /// 事务1 - 全SQL异步
        /// </summary>
        /// <param name="sqlarr">多条SQL</param>
        /// <param name="param">param</param>
        /// <returns></returns>
        public async Task<int> ExecuteTransactionAsync<T>(string[] sqlarr) where T : class
        {
            using (connection = DbConnection<T>())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int result = 0;
                        foreach (var sql in sqlarr)
                        {
                            result += await connection.ExecuteAsync(sql, null, transaction);
                        }

                        transaction.Commit();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return 0;
                    }
                }
            }
        }
        /// <summary>
        /// 事务2 - 声明参数
        /// </summary>
        /// <param name="Key">多条SQL</param>
        /// <param name="Value">param</param>
        /// <returns></returns>
        public int ExecuteTransaction<T>(Dictionary<string, object> dic) where T : class
        {
            using (connection = DbConnection<T>())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int result = 0;
                        foreach (var sql in dic)
                        {
                            result += connection.Execute(sql.Key, sql.Value, transaction);
                        }

                        transaction.Commit();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return 0;
                    }
                }
            }
        }
        /// <summary>
        /// 事务2 - 声明参数异步
        /// </summary>
        /// <param name="Key">多条SQL</param>
        /// <param name="Value">param</param>
        /// <returns></returns>
        public async Task<int> ExecuteTransactionAsync<T>(Dictionary<string, object> dic) where T : class
        {
            using (connection = DbConnection<T>())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int result = 0;
                        foreach (var sql in dic)
                        {
                            result += await connection.ExecuteAsync(sql.Key, sql.Value, transaction);
                        }

                        transaction.Commit();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return 0;
                    }
                }
            }
        }
        /// <summary>
        /// 调用存储过程
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insertSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<object> ProcAsync<T>(string procName, object param = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write))
            {
                return await connection.ExecuteScalarAsync(procName, param, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
