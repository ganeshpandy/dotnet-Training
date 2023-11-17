using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School
{
     class Student:Teacher,Iteacher
    {

        public int Id { get; set; }
        public string Name { get; set; }          
        public Student(int Id,string Name,int StaffId,string StaffName,string Class,string Subject) :base(StaffId,StaffName,Class,Subject){
            this.Id = Id;
            this.Name = Name;
            this.StaffId = StaffId; 
            this.StaffName = StaffName;
            this.Subject = Subject;                       
            this.Class = Class;           
        }

        public void DisplayTeacherDetails(int StaffId, string StaffName, string Class, string Subject)
        {
            Console.WriteLine("Teacher Id:" + StaffId);
            Console.WriteLine("StaffName:" + StaffName);
            Console.WriteLine("Class:" + Class);
            Console.WriteLine("Subject:" + Subject);
        }

        public void DisplayStudentDetails(int Id,string Name)
        {
            Console.WriteLine("Student Id:" + Id);
            Console.WriteLine("Student Name:" + Name);
        }        
    }
}
