using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2;

namespace Test2
{
     class Worker2: Worker, IWorker
    {
       
        public string Department {  get; set; }
        public Worker2(int workerId, string name, decimal salary, DateTime dOB, string gender, long contactNo,string department)
          :base(workerId,name,salary,dOB,gender,contactNo)  
        {
            WorkerID = workerId;
            Name = name;
            Salary = salary;
            DOB = dOB;
            Gender = gender;
            ContactNo = contactNo;
            Department = department;
        }
       
        public override void DisplayDetails() 
        {            
            Console.WriteLine("Worker Name:" + Name);
            Console.WriteLine("Worker Salary:" + Salary);
            Console.WriteLine("Worker dOB:" + DOB);
            Console.WriteLine("Worker gender:" + Gender);
            Console.WriteLine("Worker contactNo:" + ContactNo);
            Console.WriteLine("Worker Department:" + Department);
        }
        public override void Enrollment()
        {
            Console.WriteLine("Worker2 Enrollemnt Method");
        }
        public override void Dispatch()
        {
            Console.WriteLine("Worker2 Dispatch Method");
        }
        public int GetworkerID()
        {
            return WorkerID;
        }
        public void SetworkerID(int WorkerId)
        {
            Console.WriteLine("WorkerId" + WorkerId);
        }

    }
}
/*Inherit from the Worker class and implement the IWorker interface.
In the Worker2 class, implement the abstract method DisplayDetails to display the details of the worker2, including all properties.
Include an additional property in the Worker class: Department(string).
Implement the methods from the IEmployee interface.
*/