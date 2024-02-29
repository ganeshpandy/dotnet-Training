using EmployeeManagement.Application.Features.Commands.DeleteBlogs;
using EmployeeManagement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Handlers.CommandHandler
{
    public class DeleteEmployeeHandler : ICommandHandler<DeleteEmployee>
    {
        private readonly IEmployee employee;

        public DeleteEmployeeHandler(IEmployee employee)
        {
            this.employee = employee;
        }

        public async Task Handle(DeleteEmployee command)
        {
            await employee.DeleteEmployee(command.DeleteEmployees.Id);
        }
    }
}
