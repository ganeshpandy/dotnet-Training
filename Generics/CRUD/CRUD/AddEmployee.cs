using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD
{
    class AddEmployee
    {
        List<Employee> list = new List<Employee>();
        Employee emp = null, OldRecord = null;        
        public void CreateEmployee()
        {
             emp = new Employee()
            {
                Id = 101,
                Name = "Jack",
                Address = "Chennai",
                Designation = "Developer",
                Phoneno = 1234567890,
                Salary = 12000,
                DOB = new DateOnly(2000, 09, 01),
                DOJ = new DateOnly(2022, 01, 01)
            };           
        }
        public void Create() 
        {
            list.Add(emp);
        }
        public void Display() 
        {
            while (true)
            {
                Console.WriteLine("Enter the option\n" + "1.Create\n" + "2.Update\n" + "3.Read\n" + "4.Delete");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                     /*   List<Employee> list = CreateEmployee();*/
                        CreateEmployee();
                        Create();
                        Console.WriteLine("Data created");
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Read();
                        break;
                    case 4:
                        Delete();
                        break;

                }
                //Console.ReadKey();
            }
        }
    

        
        public void Read() 
        {
            foreach (Employee data in list) 
            {
                Console.WriteLine("Employee ID          :" + data.Id);
                Console.WriteLine("Employee Name        :" + data.Name);
                Console.WriteLine("Employee Address     :" + data.Address);
                Console.WriteLine("Employee Designation :" + data.Designation);
                Console.WriteLine("Employee Phoneno     :" + data.Phoneno);
                Console.WriteLine("Salary               :" + data.Salary);
                Console.WriteLine("DateOfBirth          :" + data.DOB);
                Console.WriteLine("DateOfJoin           :" + data.DOJ);
            }
        }
        public void Update() 
        {
        Console.Write("Enter Employee ID to update: ");
        int UpdateEmp = int.Parse(Console.ReadLine());

           

        foreach (var data in list)
        {
            if (data.Id == UpdateEmp)
            {
                OldRecord = data;
                break;
            }
        }
        if (true)
        {
            Console.WriteLine("Enter the Id");
            emp.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Enter new the Address");
            emp.Address = Console.ReadLine();


            Console.WriteLine("Enter the Designation");
            emp.Designation = Console.ReadLine();

            Console.WriteLine("Enter the PhoneNo");
            emp.Phoneno = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Salary");
            emp.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the DateOfJoin");
            emp.DOJ = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Enter the DateOfBirth");
            emp.DOB = DateOnly.Parse(Console.ReadLine());
        }

                      
        }
        public void Delete() 
        {
            
            for (int i = 0; i < list.Count; i++)
            {
            list.Clear();
            }
        }
    }
}
