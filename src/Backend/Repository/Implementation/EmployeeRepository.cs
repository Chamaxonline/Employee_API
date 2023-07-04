
using Entity.Context;
using Entity.Models;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class EmployeeRepository : EfRepository<Employee>, IEmployeeRepository
    {
        protected EmployeeDbContext _context;
        public EmployeeRepository(EmployeeDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
