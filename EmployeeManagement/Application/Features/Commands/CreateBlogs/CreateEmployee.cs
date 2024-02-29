using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Commands.CreateBlogs
{
    public class CreateEmployee  
    {
       public Employee Employee { get; set; }
    }
}
