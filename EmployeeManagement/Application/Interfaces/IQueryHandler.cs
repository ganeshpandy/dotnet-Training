using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Interfaces
{
    public interface IQueryHandler<TQuery,TResult>
    {
        Task<IEnumerable<Employee>> Handle(TQuery query);
        //Task<Employee> Handle(int Id);

    }
}
