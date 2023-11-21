using System.Net;
using System.Xml.Linq;

namespace Employee
{
     class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee(Id, Name, Address, Designation, Phno, Salary, DOJ, DOB);

            EmployeeDetails details = new EmployeeDetails();
            List<Employee> objlist = details.SaveEmployee();
            Console.WriteLine();
            Console.WriteLine("*****************************");
            details.DisplayEmployee(objlist);



        }

    }
    
}