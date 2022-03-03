using AgileManagement.Core;
using AgileManagement.Persistence.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Persistance.EfCore.Repositories
{
    public  class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual TEntity Find(string Id)
        {
            return _dbSet.Find(Id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }
            return entity;
        }

        public virtual IQueryable<TEntity> GetQuery()
        {
            return _dbSet.AsQueryable();
        }

        public virtual IQueryable GetSqlRawQuery(string query)
        {


            return _dbSet.AsQueryable();


            //return _dbContext.Set<TEntity>().FromSqlRaw()
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);

        }

        public virtual void Remove(string Id)
        {
            var entity = Find(Id);
            _dbSet.Remove(entity);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        //public virtual void Save()
        //{
        //    _dbSet.SaveChanges();
        //}

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            return entity;
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);

        }
    }
}
