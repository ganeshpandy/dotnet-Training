using EmployeeManagement.Domain.Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Services
{
    public interface IEmployee
    {
        Task<Employee> GetEmployee(int id);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task DeleteEmployee(int id);
    }
}
