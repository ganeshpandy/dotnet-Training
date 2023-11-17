using System;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace Employee
{
    public class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Id");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string? Name = Console.ReadLine();
            Console.WriteLine("Enter Employee EmailId");
            string? EmailId = Console.ReadLine();
            Console.WriteLine("Enter Employee Address");
            string? Address = Console.ReadLine();
            Console.WriteLine("Enter Employee Phone");
            long PhoneNo = Convert.ToInt64(Console.ReadLine());
            //Object
            Employee employee=new Employee(Id,Name,EmailId,Address,PhoneNo);
            //File Location
            string FilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Employee.txt";
            //FileStream f = System.IO.File.Create(FilePath);
            string employeeData = "Employee Id:"+employee.Id + "\n Employee Name:" + employee.Name +
                "\n Employee EmailId:" + employee.EmailId + "\n Employee Address:" + employee.Address +
                "\n Employee Phone Number:" + employee.PhoneNo; 
            System.IO.File.AppendAllText(FilePath, employeeData);
             
            Console.WriteLine("Data Created:\n"+employeeData);
            //employee.Display();
        }       

    }
}