using Entity;
using Entity.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {

        #region Fields

        protected EmployeeDbContext Context;

        #endregion

        public EfRepository(EmployeeDbContext context)
        {
            Context = context;
        }

        #region Public Methods

        public async Task<T> GetById(int id)
        {
            return await Context.Set<T>().FindAsync(id);
        }
        public async Task<T> Create(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return await Task.FromResult(entity);
        }

        public async Task<T> Update(T entity)
        {
            // In case AsNoTracking is used
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return await Task.FromResult(entity);

        }

        public Task Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            return Context.SaveChangesAsync();
        }
        
        #endregion

    }
}
