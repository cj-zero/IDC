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
                        dbConnections.TryAdd(values[1].ToString(), dbConnection);
                        return dbConnection;
                    }
                }
            }
            throw new Exception("当前实体未指向数据库");
        }
       
        public T Add<T>(string insertSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return connection.ExecuteScalar<T>(insertSql, entity);
            }
        }

        public async Task<T> AddAsync<T>(string insertSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return await connection.ExecuteScalarAsync<T>(insertSql, entity);
            }
        }

        public async Task<int> BatchAddAsync<T>(string insertSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return await connection.ExecuteAsync(insertSql, entity);
            }  
        }

        public async Task<IDataReader> GetAddAsync<T>(string insertSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return await connection.ExecuteReaderAsync(insertSql, entity);
            }  
        }

        public int UpDate<T>(string updateSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return connection.Execute(updateSql, entity);
            }
        }

        public async Task<int> UpDateAsync<T>(string updateSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return await connection.ExecuteAsync(updateSql, entity);
            }
        }

        public int Delete<T>(string deleteSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return connection.Execute(deleteSql, entity);
            }  
        }

        public async Task<int> DeleteAsync<T>(string deleteSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>(WriteAndReadEnum.Write)) 
            {
                return await connection.ExecuteAsync(deleteSql, entity);
            } 
        }

        public IEnumerable<dynamic> Find<T>(string selectSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>()) 
            {
                return connection.Query(selectSql, entity);
            } 
        }

        public async Task<IEnumerable<dynamic>> FindAsync<T>(string selectSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>()) 
            {
                return await connection.QueryAsync(selectSql, entity);
            } 
        }

        public dynamic Detail<T>(string selectSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>()) 
            {
                return connection.QueryFirst(selectSql, entity);
            }
        }

        public async Task<dynamic> DetailAsync<T>(string selectSql, DynamicParameters entity = null) where T : class
        {
            using (connection = DbConnection<T>()) 
            {
                return await connection.QueryFirstAsync(selectSql, entity);
            } 
        }

    }
}
