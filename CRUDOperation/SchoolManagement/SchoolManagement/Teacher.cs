using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Teacher : Student
    {
        public int Teacher_ID { get; set; }
        public string TeacherName { get; set; }

        public List<Teacher> teacherList = new List<Teacher>();

        public static List<Student> studentList = new List<Student>();
        Student newGrade = null;

        Teacher newRecord = null;
        
        public void CreateTeacher()
        {
            Teacher teach = null;
            Console.WriteLine("Are You New Teacher Press 'Y' or else 'N' ");
            char condtion=char.Parse(Console.ReadLine().ToUpper());

            while (condtion=='Y')
            {
                //Console.Clear();

                teach = new Teacher();

                Console.Write("Enter Teacher ID : "); 
                teach.Teacher_ID = int.Parse(Console.ReadLine());

                if (FindTeacher(teach.Teacher_ID))
                {
                    Console.WriteLine(TeacherID + "Is Already Present");
                    continue;
                }
                else
                {
                    Console.WriteLine("Teacher ID not found. So It Created New Teacher Record !");
                }

                Console.Write("Enter Teacher Name : "); 
                teach.TeacherName = Console.ReadLine();

                teacherList.Add(teach);

                Console.WriteLine("Teacher Record "+TeacherID+"S uccessfully Added To The List !!");

                Console.WriteLine("Finshed Added Techer Record Press 'Y' To Exit");
                if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
                    break;
                Console.Clear();
            }

        }



        public void CreateStudents()
        {
            char x = ' ';
            do
            {
                Console.Clear();

                Console.Write("Enter Teacher ID To Add Student  :  ");
                int teacherid = int.Parse(Console.ReadLine());

                if (FindTeacher(teacherid))
                {
                    Student stud = new Student();

                    Console.Write("Enter Student RollNo : ");
                    stud.RollNo = int.Parse(Console.ReadLine()!);

                    Console.Write("Enter Student Name : ");
                    stud.StudentName = Console.ReadLine();

                    Console.Write("Enter Student Gender : ");
                    stud.Gender = Console.ReadLine()!;

                    Console.Write("Enter Student Date Of Birth : ");
                    stud.DOB = DateOnly.Parse(Console.ReadLine()!);

                    Console.Write("Enter Student Address : ");
                    stud.Address = Console.ReadLine()!;

                    Console.Write("Enter Student Grade : ");
                    stud.Grade = char.Parse(Console.ReadLine()!);

                    stud.TeacherID = newRecord.Teacher_ID;

                    studentList.Add(stud);

                    Console.WriteLine("Student Record Added Successfully !!");
                   
                }
                else
                {
                    
                    //Console.WriteLine("!!!Teacher ID not Found!!!");
                    Console.WriteLine("First Create New Teaacher");
                    CreateTeacher();
                    Console.ReadKey();
                }

                Console.Write("Enter 'N' To Break  "); 
                x = char.Parse(Console.ReadLine()!.ToUpper());
            }
            while (x != 'N');
        }
        public void Update()
        {
            Console.Write("Enter Student RollNo To Update: ");
            int rollNo = int.Parse(Console.ReadLine()!);

            if (FindStudent(rollNo))
            {
                Console.Write("Enter Grade to change Grade or exit : ");
                string? option = Console.ReadLine().ToLower();

                if (option == "grade")
                {
                    Console.Write("Enter new grade : ");
                    newGrade.Grade = Char.Parse(Console.ReadLine()!);
                    Console.WriteLine("Student Grade Updated!");
                }
            }
            else
            {
                Console.Write("No student rollNo found!");
            }
        }

        public void Read()
          {
            Console.Clear();                     

            foreach (var teacher in teacherList)
            {
                Console.WriteLine("Teacher ID   :  " + teacher.Teacher_ID + "  Teacher Name  :  " + teacher.TeacherName);
            }

            foreach (var student in studentList)
            {
                Console.WriteLine("Student Teacher ID : " + student.TeacherID);
                Console.WriteLine("Student Name       : " + student.StudentName);
                Console.WriteLine("Student RollNo     : " + student.RollNo);
                Console.WriteLine("Student Gender     : " + student.Gender);
                Console.WriteLine("Student DOB        : " + student.DOB);
                Console.WriteLine("Student Address    : " + student.Address);
                Console.WriteLine("Student Grade      : " + student.Grade);
            }
            Console.ReadKey();
        }

        public void Delete() 
        {
            if (studentList != null && studentList.Count > 0)
            {
                Console.WriteLine("Enter rollnum to delete : ");
                int deleteRollNo = int.Parse(Console.ReadLine()!);

                foreach (var item in studentList)
                {
                    if (item.RollNo == deleteRollNo)
                    {
                        studentList.Remove(item);
                        Console.WriteLine("Records deleted!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Rollnumber  Not Found!");
            }
        }

        public void Function()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the option\n" + "1.CreateTeacher\n" + "2.Update\n" + "3.Read\n" + "4.Delete\n"+"5.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CreateTeacher();
                        CreateStudents();
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
                    case 5:                      
                        Console.WriteLine("Exited");
                        break;

                    default: 
                        Console.WriteLine("Invalid Option");
                        break;

                }
            }

        }
        public bool FindTeacher(int teacherid)
        {
            foreach (var data in teacherList)
            {
                if (data.Teacher_ID == teacherid)
                {
                    newRecord = data;
                    return true;
                }
            }
            return false;
        }
        public bool FindStudent(int rollNo) 
        {
            foreach (var data in studentList) 
            {
                if (data.RollNo==rollNo) 
                {
                    newGrade = data; 
                    return true;
                }
            }
            return false;
        }               
    }
}
