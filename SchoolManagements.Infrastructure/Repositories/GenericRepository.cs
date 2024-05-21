using Microsoft.EntityFrameworkCore;
using SchoolManagements.Application.Interfaces;
using SchoolManagements.Domain.Common;
using SchoolManagements.Infrastructure.Persistences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagements.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseAuditableEntity
    {

        #region Propriétes

        private readonly SchoolManagementDbContext _dbContext;
        #endregion

        #region Constructors
        public GenericRepository(SchoolManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Ovveride Methods

        public IQueryable<T> Entities => _dbContext.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return Task.CompletedTask;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbContext
                 .Set<T>()
                 .ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            T exist = _dbContext.Set<T>().Find(entity.Id);
            _dbContext.Entry(exist).CurrentValues.SetValues(entity);
            return Task.CompletedTask;
        }
        #endregion
    }
}
