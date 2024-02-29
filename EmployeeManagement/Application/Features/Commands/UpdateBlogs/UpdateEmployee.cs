using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Commands.UpdateBlogs
{
    public class UpdateEmployee
    {
        public int Id { get; set; }
        public Employee UpdateEmployees { get; set; }

    }
}
