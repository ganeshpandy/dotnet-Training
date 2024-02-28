using EmployeeManagement.Application.Services;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Repository
{
    public class AttendanceRespository : IAttendance
    {
        private readonly DataContext _context;

        public AttendanceRespository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Attendance>> GetAllAttendance()
        {
            return await _context.Attendances.ToListAsync();
        }
        public async Task<Attendance> GetAttendance(int id)
        {
            return await _context.Attendances
               .FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Attendance> AddAttendance(Attendance Attendance)
        {
            var result = await _context.Attendances.AddAsync(Attendance);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Attendance> UpdateAttendance(Attendance Attendance)
        {
            var result = await _context.Attendances
                    .FirstOrDefaultAsync(C => C.Id == Attendance.Id);
            if (result != null)
            {
               
            }
            return result;
        }
        public async Task DeleteAttendance(int id)
        {
            var result = await _context.Attendances
             .FirstOrDefaultAsync(C => C.Id == id);
            if (result != null)
            {
                _context.Attendances.Remove(result);
                await _context.SaveChangesAsync();
            }
            
        }
    }
}
