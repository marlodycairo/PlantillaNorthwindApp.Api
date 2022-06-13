using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Infrastructure.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<Employee>> GetEmployees()
        {
            return Ok(await _employeeService.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public async Task<Employee> GetEmployee(int id)
        {
            return await _employeeService.GetEmployeeById(id);
        }

        [HttpPost]
        public async Task CreateEmployee([FromBody] Employee employee)
        {
            await _employeeService.CreateEmployee(employee);
        }

        [HttpPut("{id}")]
        public async Task UpdateEmployee([FromBody] Employee employee)
        {
            await _employeeService.UpdateEmployee(employee);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task DeleteEmployee(int id)
        {
            await _employeeService.DeleteEmployee(id);
        }
    }
}
