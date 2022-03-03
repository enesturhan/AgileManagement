
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Core
{
    /// <summary>
    /// Abstract class olan Entityden kalıtım alan birşeye ancak Repository uygulanabilir.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();

        TEntity Find(string Id);

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity entity);
        void Remove(TEntity entity);

        TEntity Update(TEntity entity);
        void Save();
        void Add(TEntity entity);
        void Remove(string Id);

        /// <summary>
        /// Linq query
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetQuery();
        /// <summary>
        /// Sql query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IQueryable GetSqlRawQuery(string query);
    }
}
