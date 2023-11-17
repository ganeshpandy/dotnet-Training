using School;
using System.Security.Claims;
using System;
using System.Xml.Linq;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Student ID:");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Student Name:");
            string Name = Console.ReadLine();            
            
            Console.WriteLine("Enter the Staff ID:");
            int StaffId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Staff Name:");
            string StaffName = Console.ReadLine();

            Console.WriteLine("Enter the Staff Class:");
            string Class = Console.ReadLine();

            Console.WriteLine("Enter the Staff Subjecct:");
            string Subject = Console.ReadLine();
            Console.WriteLine("==============================");

            Student student =new Student(Id,Name,StaffId,StaffName,Class,Subject);
            
            student.DisplayStudentDetails(Id, Name);
            student.DisplayTeacherDetails(StaffId, StaffName, Class, Subject);
        }
    }
}
