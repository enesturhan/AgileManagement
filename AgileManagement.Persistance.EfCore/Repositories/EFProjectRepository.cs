using AgileManagement.Core;
using AgileManagement.Domain;
using AgileManagement.Domain.Models;
using AgileManagement.Persistance.EfCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Persistence.EF
{
    public class EFProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public EFProjectRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Project entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Project entity)
        {
            throw new NotImplementedException();
        }

        public Project Find(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Project> GetQuery()
        {
            throw new NotImplementedException();
        }

        public IQueryable GetSqlRawQuery(string query)
        {
            throw new NotImplementedException();
        }

        public void Remove(Project entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(string Id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Project Update(Project entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Project> Where(Expression<Func<Project, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
