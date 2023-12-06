using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM
{
    public class Teacher : Student
    {
        public int Teacher_ID { get; set; }
        public string TeacherName { get; set; }

        public List<Teacher> teacherList = new List<Teacher>();

        public static List<Student> studentList = new List<Student>();
        Teacher newRecord = null;

        public void CreateTeacher()
        {
            Teacher teach = null;
            while (true)
            {
                Console.Clear();

                teach = new Teacher();

                Console.Write("Enter Teacher ID : "); teach.Teacher_ID = int.Parse(Console.ReadLine());

                if (FindTeacher(teach.Teacher_ID))
                {
                    Console.WriteLine(TeacherID + "Is Already Present");
                    continue;
                }
                else
                {
                    Console.WriteLine("Teacher ID not found. So It Created New Teacher Record !");
                }

                Console.Write("Enter Teacher Name : "); teach.TeacherName = Console.ReadLine();

                teacherList.Add(teach);

                Console.WriteLine("Teacher Record Successfully Added To The List !!");

                Console.Write("Enter [ N ] To Break  -  ");

                if (char.Parse(Console.ReadLine()) == 'N')
                    break;
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
                    stud.RollNo = int.Parse(Console.ReadLine());

                    Console.Write("Enter Student Name : ");
                    stud.StudentName = Console.ReadLine();

                    //Console.Write("Enter Student Gender : ");
                    //stud.Gender = Console.ReadLine();

                    //Console.Write("Enter Student Date Of Birth : ");
                    //stud.DOB = Date.Parse(Console.ReadLine());

                    //Console.Write("Enter Student Address : ");
                    //stud.Address = Console.ReadLine();

                    //Console.Write("Enter Student Grade : ");
                    //stud.Grade = char.Parse(Console.ReadLine());

                    stud.TeacherID = newRecord.Teacher_ID;

                    studentList.Add(stud);

                    Console.WriteLine("Student Record Added Successfully !!");


                }
                else
                {
                    Console.WriteLine("Teacher ID not Found !!");
                }

                Console.Write("Enter [ N ] To Break  - "); x = char.Parse(Console.ReadLine());
            }
            while (x != 'N');
        }
        public void Update() { }

        public void Read()
        {
            Console.Clear();

            foreach (var teacher in teacherList)
            {
                Console.WriteLine("Teacher ID   :  " + teacher.Teacher_ID + "  Teacher Name  :  " + teacher.TeacherName);
            }

            foreach (var student in studentList)
            {
                Console.WriteLine("Student Name : " + student.StudentName + "  Student Teacher ID  : " + student.TeacherID);
            }
            Console.ReadKey();
        }

        public void Delete() { }

        public void Function()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the option\n" + "1.CreateTeacher\n" + "2.Update\n" + "3.Read\n" + "4.Delete");
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
    }
}
