using EmployeeManagement.Application.Features.Queries;
using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Handlers.QueryHandler
{
    public class GetEmpByIdHandler : IQueryHandler<GetEmployee, Employee>
    {
        private readonly IEmployee employee;

        public GetEmpByIdHandler(IEmployee employee)
        {
            this.employee = employee;
        }

        public Task<IEnumerable<Employee>> Handle(GetEmployee query)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> Handle(int id)
        {
            return await employee.GetEmployee(id);
        }
    }
}
