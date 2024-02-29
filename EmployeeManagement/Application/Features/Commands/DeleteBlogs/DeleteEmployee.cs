using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Commands.DeleteBlogs
{
    public class DeleteEmployee 
    {
        public int Id { get; set; }
        public Employee DeleteEmployees { get; set; }
    }
}
