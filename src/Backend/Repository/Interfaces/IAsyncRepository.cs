
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IAsyncRepository<T> where T: class
    {

        Task<T> GetById(int id);
        
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
        

    }
}
