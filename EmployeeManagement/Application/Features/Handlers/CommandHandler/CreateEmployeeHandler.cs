using EmployeeManagement.Application.Features.Commands.CreateBlogs;
using EmployeeManagement.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeManagement.Application.Features.Handlers.CommandHandler
{
    public class CreateEmployeeHandler : ICommandHandler<CreateEmployee>
    {
        private readonly IEmployee employee;

        public CreateEmployeeHandler(IEmployee employee)
        {
            this.employee = employee;
        }
        
        public async Task Handle(CreateEmployee command)
        {
            await employee.AddEmployee(command.Employee);
        }
    }
}
