using EmployeeManagement.Application.Services;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Queries
{
    public class GetEmployee : IEmployee
    {
        private readonly DataContext _contextDB;
        public GetEmployee(DataContext contextDB)
        {
            _contextDB = contextDB;
        }
        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _contextDB.Employees.ToListAsync();
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

         async Task<Employee> IEmployee.GetEmployee(int id)
        {
            return await _contextDB.Employees.FirstOrDefaultAsync(e => e.Id.Equals(id));
        }
    }
}
