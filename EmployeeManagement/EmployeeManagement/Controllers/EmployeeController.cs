using AutoMapper;
using EmployeeManagement.Application.Features.Queries;
using EmployeeManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediatR;
        private readonly IMapper mapper;

        public EmployeeController(IMediator mediatR, IMapper mapper)
        {
            this.mediatR = mediatR;
            this.mapper = mapper;
        }

        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var query = new GetEmployee(); // No arguments needed
            var employees = await mediatR.Send(query);

            if (employees == null)
            {
                return NotFound(); // No employees found
            }

            return Ok(employees);
        }
        /*[HttpGet("GetemployeeById")]
        public async Task<Employee> GetemployeeById(int id)
        {
            var get = await employee.GetEmployee(id);
            return get;
        }*/
        /*[HttpPost("AddEmployee")]
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
        }*/
    }
}
