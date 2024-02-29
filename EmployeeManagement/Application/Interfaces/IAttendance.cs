using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Interfaces
{
    public interface IAttendance
    {
        Task<Attendance> GetAttendance(int id);       
        Task<IEnumerable<Attendance>> GetAllAttendance();
        Task<Attendance> AddAttendance(Attendance attendance);
        Task<Attendance> UpdateAttendance(Attendance attendance);


    }
}
