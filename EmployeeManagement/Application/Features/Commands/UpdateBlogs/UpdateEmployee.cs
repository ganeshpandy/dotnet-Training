using EmployeeManagement.Application.Services;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Commands.UpdateBlogs
{
    public class UpdateEmployee : IEmployee
    {
        private readonly DataContext _contextDB;
        public UpdateEmployee(DataContext contextDB)
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

        public Task<IEnumerable<Employee>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        async Task<Employee> IEmployee.UpdateEmployee(Employee employee)
        {
            var result = await _contextDB.Employees.FirstOrDefaultAsync(e => e.Id.Equals(employee.Id));
            if (result != null)
            {
                result.Address = employee.Address;
                result.PhoneNumber = employee.PhoneNumber;
                result.Designation = employee.Designation;
                await _contextDB.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
