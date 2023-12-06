using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Student
    {
        public int TeacherID { get; set; }
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public DateOnly DOB { get; set; }
        public string Address { get; set; }
        public char Grade { get; set; }

    }
}


/*Create a Student: Allow the teacher to input a 
 * student's name, roll number, gender, date of birth, address and grade, and add it to the list of students assigned to them.*/
 