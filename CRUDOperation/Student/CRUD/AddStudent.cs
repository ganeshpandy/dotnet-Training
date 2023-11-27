using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD
{
    class AddStudent
    {
        List<Student> list = new List<Student>();
        Student stud = null, OldRecord = null;        
        public void CreateStudent()
        {
             stud = new Student()
            {
                Id = 101,
                Name = "Jack",
                Address = "Chennai",
                Standard = "10th",
                Phoneno = 1234567890,
                Fees = 12000,
                DOB = new DateOnly(2000, 09, 01),
                DOJ = new DateOnly(2022, 01, 01)
            };           
        }
        public void Create() 
        {
            list.Add(stud);
        }
        public void Display() 
        {
            while (true)
            {
                Console.WriteLine("Enter the option\n" + "1.Create\n" + "2.Update\n" + "3.Read\n" + "4.Delete");
                int option = int.Parse(Console.ReadLine()!);

                switch (option)
                {
                    case 1:                     
                        CreateStudent();
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
            foreach (Student data in list) 
            {
                Console.WriteLine("Student ID          :" + data.Id);
                Console.WriteLine("Student Name        :" + data.Name);
                Console.WriteLine("Student Address     :" + data.Address);
                Console.WriteLine("Student Designation :" + data.Standard);
                Console.WriteLine("Student Phoneno     :" + data.Phoneno);
                Console.WriteLine("Salary               :" + data.Fees);
                Console.WriteLine("DateOfBirth          :" + data.DOB);
                Console.WriteLine("DateOfJoin           :" + data.DOJ);
            }
        }
        public void Update() 
        {
        Console.Write("Enter Student ID to update: ");
        int UpdateStud = int.Parse(Console.ReadLine()!);

        foreach (var data in list)
        {
            if (data.Id == UpdateStud)
            {
                OldRecord = data;
                break;
            }
        }
        if (true)
        {
            Console.WriteLine("Enter the Id");
            stud.Id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the Name");
            stud.Name = Console.ReadLine()!;

            Console.WriteLine("Enter new the Address");
            stud.Address = Console.ReadLine()!;

            Console.WriteLine("Enter the Designation");
            stud.Standard = Console.ReadLine()!;

            Console.WriteLine("Enter the PhoneNo");
            stud.Phoneno = long.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the Fees");
            stud.Fees = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the DateOfJoin");
            stud.DOJ = DateOnly.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the DateOfBirth");
            stud.DOB = DateOnly.Parse(Console.ReadLine()!);
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
