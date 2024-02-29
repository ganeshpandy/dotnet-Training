using EmployeeManagement.Application.Features.Queries;
using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EmployeeManagement.Application.Features.Handlers.QueryHandler
{
    public class GetEmployeeHanlder : IQueryHandler<GetEmployee, IEnumerable<Employee>>
    {
        private readonly IEmployee employee;

        public GetEmployeeHanlder(IEmployee employee)
        {
            this.employee = employee;
        }

        public async Task<IEnumerable<Employee>> Handle(GetEmployee query)
        {
            return await employee.GetAllEmployees();
        }

        public Task<Employee> Handle(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
