using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IDC.Repository.Core
{
    /// <summary>
    /// 工作单元接口
    /// <para> 适合在一下情况使用:</para>
    /// <para>1 在同一事务中进行多表操作</para>
    /// <para>2 需要多表联合查询</para>
    /// <para>因为架构采用的是EF访问数据库，暂时可以不用考虑采用传统Unit Work的注册机制</para>
    /// </summary>
    public interface IUnitWork
    {
        DbContext GetDbContext<T>() where T : class;
        T FindSingle<T>(Expression<Func<T, bool>> exp = null) where T : class;
        Task<T> FindSingleAsync<T>(Expression<Func<T, bool>> exp = null, CancellationToken cancellationToken = default) where T : class;
        bool IsExist<T>(Expression<Func<T, bool>> exp) where T : class;
        Task<bool> IsExistAsync<T>(Expression<Func<T, bool>> exp, CancellationToken cancellationToken = default) where T : class;
        IQueryable<T> Find<T>(Expression<Func<T, bool>> exp = null) where T : class;
        IQueryable<T> FindTrack<T>(Expression<Func<T, bool>> exp = null) where T : class;

        //IQueryable<T> Find<T>(int pageindex = 1, int pagesize = 10, string orderby = "",
        //     Expression<Func<T, bool>> exp = null) where T : class;

        int GetCount<T>(Expression<Func<T, bool>> exp = null) where T : class;
        Task<int> GetCountAsync<T>(Expression<Func<T, bool>> exp = null, CancellationToken cancellationToken = default) where T : class;

        void Add<T>(T entity) where T : BaseEntity;
        T Add<T, TKey>(T entity) where T : class;
        Task<T> AddAsync<T>(T entity, CancellationToken cancellationToken = default) where T : BaseEntity;
        Task<T> AddAsync<T, Tkey>(T entity, CancellationToken cancellationToken = default) where T : class;

        void BatchAdd<T>(T[] entities) where T : BaseEntity;
        void BatchAdd<T, TKey>(T[] entities) where T : class;
        Task BatchAddAsync<T>(T[] entities, CancellationToken cancellationToken = default) where T : BaseEntity;
        Task BatchAddAsync<T, TKey>(T[] entities, CancellationToken cancellationToken = default) where T : class;

        /// <summary>
        /// 更新一个实体的所有属性
        /// </summary>
        void Update<T>(T entity) where T : class;
        Task UpdateAsync<T>(T entity, CancellationToken cancellationToken = default) where T : class;

        void BatchUpdate<T>(T[] entity) where T : class;

        Task BatchUpdateAsync<T>(T[] entity, CancellationToken cancellationToken = default) where T : class;


        void Delete<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity, CancellationToken cancellationToken = default) where T : class;

        void BatchDelete<T>(T[] entity) where T : class;
        Task BatchDeleteAsync<T>(T[] entity, CancellationToken cancellationToken = default) where T : class;


        /// <summary>
        /// 实现按需要只更新部分更新
        /// <para>如：Update<T>(u =>u.Id==1,u =>new User{Name="ok"}) where T:class;</para>
        /// </summary>
        /// <param name="where">更新条件</param>
        /// <param name="entity">更新后的实体</param>
        void Update<T>(Expression<Func<T, bool>> where, Expression<Func<T, T>> entity) where T : class;
        //Task UpdateAsync<T>(Expression<Func<T, bool>> where, Expression<Func<T, T>> entity, CancellationToken cancellationToken = default) where T : class;
        /// <summary>
        /// 批量删除
        /// </summary>
        void Delete<T>(Expression<Func<T, bool>> exp) where T : class;
        Task DeleteAsync<T>(Expression<Func<T, bool>> exp, CancellationToken cancellationToken = default) where T : class;

        void Save();
        Task SaveAsync(CancellationToken cancellationToken = default);

      
    }
}
