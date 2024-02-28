using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Models
{
    public class AddEmployeeDTO
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string PersonalEmail { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoin { get; set; }
        public DateTime DateOfRelieving { get; set; }
        public bool IsIntern { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}
