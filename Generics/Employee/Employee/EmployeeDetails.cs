using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee
{
     class EmployeeDetails
    {
        public List<Employee> SaveEmployee()
        {
            Console.WriteLine("Enter the Id");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter the Address");
            string Address = Console.ReadLine();

            Console.WriteLine("Enter the Designation");
            string Designation = Console.ReadLine();

            Console.WriteLine("Enter the PhoneNo");
            long Phoneno = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Salary");
            double Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the DateOfJoin");
            DateOnly DOJ = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Enter the DateOfBirth");
            DateOnly DOB = DateOnly.Parse(Console.ReadLine());

            //Employee employee = new Employee(Id, Name, Address, Designation, Phno, Salary, DOJ, DOB);
            List<Employee> Employees = new List<Employee>();

            //Id,Name,Address,Designation,Phno,Salary,DOJ,DOB
            List<Employee> list = new List<Employee>()
            {
                new Employee(){ Id=Id,Name=Name,Address=Address,Designation=Designation,Phoneno=Phoneno,Salary=Salary,DOJ=DOJ,DOB=DOB}
            };
            return list;
        }
        public void DisplayEmployee(List<Employee>employees)
        {
            foreach (var emp in employees) 
            { 
                Console.WriteLine("Employee ID          :"+emp.Id);
                Console.WriteLine("Employee Name        :"+emp.Name);
                Console.WriteLine("Employee Address     :"+emp.Address);
                Console.WriteLine("Employee Designation :"+emp.Designation);
                Console.WriteLine("Employee Phoneno     :" + emp.Phoneno);
                Console.WriteLine("Employee Salary      :" + emp.Salary);
                Console.WriteLine("Employee DOJ         :" + emp.DOJ);
                Console.WriteLine("Employee DOB         :" + emp.DOB);
            }
        }




    }
}
