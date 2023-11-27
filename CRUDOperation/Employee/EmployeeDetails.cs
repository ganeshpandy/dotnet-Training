using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Employee
{
    public class EmployeeDetails : SaveEmployee
    {
        List<SaveEmployee> employees = new List<SaveEmployee>();
        public List<SaveEmployee> Create()
        {
            SaveEmployee employee = new SaveEmployee();

            Console.Write("Enter Employee ID : ");
            employee.EmployeeId = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name : ");
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Enter Employee Address : ");
            employee.EmployeeAddress = Console.ReadLine();

            Console.Write("Enter Employee Email : ");
            employee.EmployeeEmail = Console.ReadLine();

            Console.Write("Enter Employee Phone Number : ");
            employee.PhoneNumber = long.Parse(Console.ReadLine()!);

            Console.Write("Enter Employee Date Of Birth : ");
            employee.DateOfBirth = DateOnly.Parse(Console.ReadLine());

            SaveEmployee getEmployee = new SaveEmployee
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                EmployeeAddress = employee.EmployeeAddress,
                EmployeeEmail = employee.EmployeeEmail,
                PhoneNumber = employee.PhoneNumber,
                DateOfBirth = employee.DateOfBirth,                
                Salary= employee.Salary,                
            };
            employees.Add(getEmployee);
            Console.WriteLine("Employee details created!");
            return employees;
        }
        public void Read()
        {
            if(employees != null && employees.Count > 0)
            {
                foreach (var company in employees)
                {
                    Console.WriteLine("Employee ID          :" + company.EmployeeId);
                    Console.WriteLine("Employee Name        :" + company.EmployeeName);
                    Console.WriteLine("Employee Address     :" + company.EmployeeAddress);
                    Console.WriteLine("Employee Designation :" + company.EmployeeEmail);
                    Console.WriteLine("Employee Phoneno     :" + company.PhoneNumber);
                    Console.WriteLine("Salary               :" + company.Salary);
                    Console.WriteLine("DateOfBirth          :" + company.DateOfBirth);                                 
                }
            }
            else
            {
                Console.WriteLine("No details found!, please enter details");
            }
        }
        public void Update()
        {
            Console.Write("Enter passenger ID to update: ");
            int UpdateEmp = int.Parse(Console.ReadLine()!);

            SaveEmployee existingEmployee = null!;

            foreach (var emp in employees)
            {
                if (emp.EmployeeId == UpdateEmp)
                {
                    existingEmployee = emp;
                    break;
                }
            }
            if (existingEmployee != null)
            {
                Console.Write("Enter New Employee Name: ");
                existingEmployee.EmployeeName = Console.ReadLine();

                Console.Write("Enter New Employee Address: ");
                existingEmployee.EmployeeAddress = Console.ReadLine();

                Console.Write("Enter New Employee Email : ");
                existingEmployee.EmployeeEmail = Console.ReadLine();

                Console.Write("Enter New Employee Phone Number : ");
                existingEmployee.PhoneNumber = long.Parse(Console.ReadLine()!);

                Console.Write("Enter New Employee Date Of Birth : ");
                existingEmployee.DateOfBirth = DateOnly.Parse(Console.ReadLine()!);
                
                Console.Write("Enter New Salary : ");
                existingEmployee.Salary = double.Parse(Console.ReadLine()!);

                Console.WriteLine("Employee details updated!");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }
        public void Delete()
        {
            if (employees.Count > 0)
            {
                employees.Clear();
                Console.WriteLine("All records deleted!");
            }
            else
            {
                Console.WriteLine("No records found!");
            }
        }
    }
}
