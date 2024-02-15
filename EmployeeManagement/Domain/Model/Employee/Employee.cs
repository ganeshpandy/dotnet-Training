using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Domain.Model.Company;

namespace EmployeeManagement.Domain.Model.Employee
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CompanyId { get; set; }
        public Company.Company Company { get; set; }
    }
}
