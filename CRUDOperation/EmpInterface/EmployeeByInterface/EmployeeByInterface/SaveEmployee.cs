using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeByInterface
{
    class SaveEmployee : EmployeeDetails, IEmployee     
    {
        List<EmployeeDetails> list = new List<EmployeeDetails>();
        EmployeeDetails employee = null, OldData = null;
        
        public List<EmployeeDetails> Create()
        {
            EmployeeDetails employee = new EmployeeDetails();

            Console.Write("Enter Employee ID : ");
            employee.EmployeeId = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Employee Name : ");
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Enter Employee Address : ");
            employee.Address = Console.ReadLine();

            Console.Write("Enter Employee Email : ");
            employee.Email = Console.ReadLine();

            Console.Write("Enter Employee Phone Number : ");
            employee.PhoneNo = long.Parse(Console.ReadLine()!);

            Console.Write("Enter Employee Date Of Birth : ");
            employee.DateOfBirth = DateOnly.Parse(Console.ReadLine()!);

           
            Console.Write("Enter Salary : ");
            employee.Salary = double.Parse(Console.ReadLine()!);

            //EmployeeDetails getEmployee = new EmployeeDetails
              employee = new EmployeeDetails()
                {
                    EmployeeId = employee.EmployeeId,
                    EmployeeName = employee.EmployeeName,
                    Address = employee.Address,
                    Email = employee.Email,
                    PhoneNo = employee.PhoneNo,
                    DateOfBirth = employee.DateOfBirth,                   
                    Salary = employee.Salary,                    
                };
                list.Add(employee);
                Console.WriteLine("Employee details created!");
                return list;            
        }
       
        public void Read()
        {
            if (list.Count > 0)
            {
                foreach (var company in list)
                {
                    Console.WriteLine("Employee Id            : " + company.EmployeeId);
                    Console.WriteLine("Employee Name          : " + company.EmployeeName);
                    Console.WriteLine("Employee Address       : " + company.Address);
                    Console.WriteLine("Employee Email         : " + company.Email);
                    Console.WriteLine("Phone Number           : " + company.PhoneNo);
                    Console.WriteLine("Date Of Birth          : " + company.DateOfBirth);
                    Console.WriteLine("Salary                 : " + company.Salary);
                }
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }

        }
        public void Delete()
        {
            if (true)
            {               
                    list.Clear();
                    Console.WriteLine("All records deleted!");                
            }
            else
            {
                Console.WriteLine("No records found!");
            }
        }

       

        public void Update()
        {            
            Console.Write("Enter Employee ID to update: ");
            int UpdateEmp = int.Parse(Console.ReadLine()!);
            foreach (var data in list)
            {
                if (data.EmployeeId == UpdateEmp)
                {
                    OldData = data;
                    break;
                }
            }
            Console.WriteLine("Enter the Id");
            employee.EmployeeId = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the Name");
            employee.EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter new the Address");
            employee.Address = Console.ReadLine();

            Console.WriteLine("Enter the Email");
            employee.Email = Console.ReadLine();

            Console.Write("Enter New Employee Date Of Birth : ");
            employee.DateOfBirth = DateOnly.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the PhoneNo");
            employee.PhoneNo = long.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the Salary");
            employee.Salary = double.Parse(Console.ReadLine()!);                      
 //int EmployeeId, string EmployeeName, string Address, string Email, long PhoneNo, DateOnly DateOfBirth, double Salary
        }   

    }
}
