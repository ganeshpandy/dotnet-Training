using EmployeeManagement.Application.Services;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Commands.CreateBlogs
{
    public class CreateEmployee : IEmployee
    {
        private readonly DataContext  _contextDB;
        public CreateEmployee(DataContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var addEmp= await _contextDB.Employees.AddAsync(employee);
            await _contextDB.SaveChangesAsync();
            return addEmp.Entity;
        }

        public Task DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
           return await _contextDB.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _contextDB.Employees.FirstOrDefaultAsync(e => e.Id.Equals(id));
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
