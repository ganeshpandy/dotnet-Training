using EmployeeManagement.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Queries
{
    public class GetEmployee:IRequest<IEnumerable<Employee>>
    {
        public int Id { get; set; }
        public Employee GetEmployees{ get; set; }
    }
}
