using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Training
{
     class StudentDetails:Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
       public static List<string> LoadStudent()
        {            
            List<int> id = new List<int>() { 101, 102, 103, 104, 105 };
            List<string> name = new List<string>() { "Alex", "Bond", "Axel", "Spike", "James" };
            return name.ToList();
        }
        public static List<string> LoadCourse()
        {
            List<int> id = new List<int>() { 101, 102,103,104,105 };
            List<string> courseName = new List<string>() { "C#", "JAVA", "Python", "JAVA", "C++" };
            List<int> amount = new List<int>() { 10000, 12000, 13000, 14000, 5000 };
            return courseName.ToList();
        }
       

}
}
