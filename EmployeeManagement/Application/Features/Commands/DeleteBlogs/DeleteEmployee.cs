using EmployeeManagement.Application.Services;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Commands.DeleteBlogs
{
    public class DeleteEmployee : IEmployee
    {
        private readonly DataContext _contextDB;
        public DeleteEmployee(DataContext contextDB)
        {
            _contextDB = contextDB;
        }
        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        async Task IEmployee.DeleteEmployee(int id)
        {
           var result=await _contextDB.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null) 
            {
                _contextDB.Employees.Remove(result);
                await _contextDB.SaveChangesAsync();    
            }
            return result;
        }
    }
}
