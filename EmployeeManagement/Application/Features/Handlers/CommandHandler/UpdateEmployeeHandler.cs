using EmployeeManagement.Application.Features.Commands.UpdateBlogs;
using EmployeeManagement.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeManagement.Application.Features.Handlers.CommandHandler
{
    public class UpdateEmployeeHandler : ICommandHandler<UpdateEmployee>
    {
        private readonly IEmployee employee;

        public UpdateEmployeeHandler(IEmployee employee)
        {
            this.employee = employee;
        }

        public async Task Handle(UpdateEmployee command)
        {
            await employee.UpdateEmployee(command.UpdateEmployees);
        }
    }
}
