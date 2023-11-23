using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public abstract class Person
    {        
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }    
        public long ContactNo {  get; set; }
        
        //public  void SetStudentID() 
        //{
        
        //}
        public abstract void Display();

        
    }
}
