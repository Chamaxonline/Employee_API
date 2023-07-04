using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Interface
{
    public interface IEmployeeService
    {
        Task<Employee> Create(Employee employee);
        Task<Employee> Get(int id);
        Task<Employee> Update(Employee employee);
        void Delete(Employee employee);

    }
}
