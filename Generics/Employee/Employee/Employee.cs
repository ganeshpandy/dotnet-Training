using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public long Phoneno { get; set; }
        public double Salary { get; set; }
        public DateOnly DOJ { get; set; } = new DateOnly();
        public DateOnly DOB { get; set; } = new DateOnly();
       /* public Employee(int id, string name, string address, string designation, long phoneno, double salary, DateOnly doj, DateOnly dob)
        {
            Id = id;
            Name = name;
            Address = address;
            Designation = designation;
            Phoneno = phoneno;
            Salary = salary;
            DOJ = doj;
            DOB = dob;
        }*/
    }
}
