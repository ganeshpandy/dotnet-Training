using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Student : Person, IStudent 
    {
       
        public string Id {  get; set; }
        public Student(string id, string firstName, string lastName, int age, long contactNo)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ContactNo = contactNo;
        }


        public override void Display() 
        {           
            Console.WriteLine("FirstName:"+ FirstName);
            Console.WriteLine("LastName:" + LastName);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("ContactNo:" + ContactNo);
            
        }
        public void EnrollCourse() 
        {
        Console.WriteLine("MCA");
        }
        public void SubmitAssignment() 
        {
            Console.WriteLine("Submit final Year project");
        }
        public string GetStudentID() 
        {
            return Id;
        }
        public  void SetStudentID(string Id)
        { 
        Console.WriteLine("Student ID:"+Id);
        }
    }
    
}
