using Domain.Service.Interface;
using Entity.Models;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeservice;
        public EmployeeController(IEmployeeService employeeservice)
        {
            _employeeservice = employeeservice;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Create(EmployeeViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var employee = Mapper.Map<Employee>(viewModel);
                var result = Mapper.Map<EmployeeViewModel>(await _employeeservice.Create(employee));
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }

        }
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var employee = await _employeeservice.Get(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }

        }

        [HttpPost]
        [Route("Update")]
        public async Task<ActionResult> Update(EmployeeViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var employee = Mapper.Map<Employee>(viewModel);
                var result = Mapper.Map<EmployeeViewModel>(await _employeeservice.Update(employee));
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }

        }

        [HttpPost]
        [Route("Delete")]
        public async Task<ActionResult> Delete(EmployeeViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var employee = Mapper.Map<Employee>(viewModel);
                _employeeservice.Delete(employee);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex.InnerException;
            }

        }
    }
}
