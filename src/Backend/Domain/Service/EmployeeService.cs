using AutoMapper;
using Domain.Service.Interface;
using Entity.Models;
using Repository.Implementation;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class EmployeeService: Profile, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Create(Employee employee)
        {            
            return await _employeeRepository.Create(employee);

        }
        public async Task<Employee> Get(int id)
        {
            return await _employeeRepository.GetById(id);
        }
        public async Task<Employee> Update(Employee employee)
        {
            return await _employeeRepository.Update(employee);
        }
        public async void Delete(Employee employee)
        {
             await (_employeeRepository.Delete(employee));
        }
    }
}
