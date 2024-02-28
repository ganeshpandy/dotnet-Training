using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain.Entities
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }
        public DateTime ClockIn { get; set; }
        public DateTime ClockOut { get; set; }
        public bool IsActive { get; set; } = false;
        public int EmpId { get; set;}
        public Employee Employee { get; set; }

    }
}
