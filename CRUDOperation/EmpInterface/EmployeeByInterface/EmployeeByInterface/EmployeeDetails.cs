using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeByInterface
{
     class EmployeeDetails
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public long PhoneNo { get; set; }
        public DateOnly DateOfBirth { get; set; }     
        public double Salary { get; set; }
        
    }
}
