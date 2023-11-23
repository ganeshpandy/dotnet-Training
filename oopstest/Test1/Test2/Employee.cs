using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    abstract class Employee
    {

        public string Name {  get; set; }
        public Decimal Salary { get; set; }
        public DateTime DOB { get; set; }
        public string Gender {  get; set; }
        public long ContactNo {  get; set; }
        public Employee(string name, decimal salary, DateTime dOB, string gender, long contactNo)
        {          
            Name = name;
            Salary = salary;
            DOB = dOB;
            Gender = gender;
            ContactNo = contactNo;
        }

        public abstract void DisplayDetails();
    }
}
/*Include five properties: Name(string), Salary(Decimal), DOB(DateTime), Gender(string), and ContactNumber(long).
Implement a parameterized constructor that initializes the Name, Salary, DOB, Gender, and ContactNumber properties.
Declare an abstract method named DisplayDetails with no parameters and a return type of void.*/