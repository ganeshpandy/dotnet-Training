using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EmployeeManagement.Infrastructure.Repository
{
    public class EmployeeRespository:IEmployee
    {
        private readonly DataContext _context;

        public EmployeeRespository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }
        public async Task<Employee> GetEmployee(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await _context.Employees
                    .FirstOrDefaultAsync(C => C.Id == employee.Id);
            if (result != null)
            {
               
            }
            return result;
        }

        public async Task<Employee> DeleteEmployee(int id)
        {
            var result = await _context.Employees
             .FirstOrDefaultAsync(C => C.Id == id);
            if (result != null)
            {
                _context.Employees.Remove(result);
                await _context.SaveChangesAsync();
            }
            return result;
        }

        

        

      
    }
}
