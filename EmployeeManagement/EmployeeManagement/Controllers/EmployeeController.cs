using EmployeeManagement.Application.Services;
using EmployeeManagement.Domain.Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee employee;

        public EmployeeController(IEmployee employee)
        {
            this.employee = employee;
        }
        [HttpGet("GetEmployees")]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var get = await employee.GetAllEmployees();
            return get;
        }
        [HttpGet("GetemployeeById")]
        public async Task<Employee> GetemployeeById(int id)
        {
            var get = await employee.GetEmployee(id);
            return get;
        }
        [HttpPost("AddEmployee")]
        public async Task<Employee> AddEmployee(Employee employeeDetails)
        {
            await employee.AddEmployee(employeeDetails);
            return employeeDetails;
        }
        [HttpPut("UpdateEmployeeDetails")]
        public async Task<Employee> UpdateEmployee(Employee employeeDetails)
        {
            var update = await employee.UpdateEmployee(employeeDetails);
            return update;
        }
        [HttpDelete("DeleteEmployee")]
        public async Task DeleteEmployee(int id)
        {
            await employee.DeleteEmployee(id);
        }
    }
}
