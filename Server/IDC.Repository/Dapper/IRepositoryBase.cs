using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Repository.Dapper
{
    public interface IRepositoryBase
    {
        IDbConnection DbConnection<T>(WriteAndReadEnum writeAndRead=WriteAndReadEnum.Read) where T : class; //开启数据库连接
        #region Add添加
        /// <summary>
        /// 添加并获取id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insertSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        T Add<T>( string insertSql, object param = null) where T : class;
        /// <summary>
        /// 异步添加并获取id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insertSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<T> AddAsync<T>( string insertSql, object param = null) where T : class;
        Task<int> BatchAddAsync<T>(string insertSql, object param = null) where T : class;
        /// <summary>
        /// 异步添加返回查询信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="insertSql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<IDataReader> GetAddAsync<T>(string insertSql, object param = null) where T : class;
        #endregion
        #region Update修改
        int UpDate<T>( string updateSql, object param = null) where T : class;//修改
        Task<int> UpDateAsync<T>( string updateSql, object param = null) where T : class;//异步修改
        #endregion
        #region Delete删除
        int Delete<T>(string deleteSql, object param = null) where T : class;//删除
        Task<int> DeleteAsync<T>( string deleteSql, object param = null) where T : class;//异步删除
        #endregion
        #region 查询
        IEnumerable<dynamic> Find<T>( string selectSql, object param = null) where T : class;//查询列表
        Task<IEnumerable<dynamic>> FindAsync<T>(string selectSql, object param = null) where T : class;//异步查询列表
        dynamic Detail<T>(string selectSql, object param = null) where T : class;//查询单个数据
        Task<IEnumerable<T>> GetAsync<T>(string selectSql, DynamicParameters entity = null) where T : class;//异步查询列表
        Task<dynamic> DetailAsync<T>(string selectSql, object param = null) where T : class;//异步查询单个数据
        #endregion
    }
}
