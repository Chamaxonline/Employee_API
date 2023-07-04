using Entity.Mappings;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.ViewModels
{
    public class EmployeeViewModel : IMapBoth<Employee>
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
}
