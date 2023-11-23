using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test2
{
     class Worker:Employee,IWorker
    {
        public int WorkerID {  get; set; }
        public Worker(int workerId, string name, decimal salary, DateTime dOB, string gender, long contactNo)
            :base(name,salary,dOB,gender,contactNo) 
        {
            WorkerID = workerId;
            Name = name;
            Salary = salary;
            DOB = dOB;
            Gender = gender;
            ContactNo = contactNo;
        }
        public override void DisplayDetails() 
        {
            Console.WriteLine("Worker Name:"+Name);
            Console.WriteLine("Worker Salary:" + Salary);            
            Console.WriteLine("Worker dOB:" + DOB);
            Console.WriteLine("Worker gender:" + Gender);
            Console.WriteLine("Worker contactNo:" + ContactNo);
        }
        public virtual void Enrollment() 
        {
        Console.WriteLine("Worker1 Enrollemnt Method");
        }
        public virtual void Dispatch()
        {
            Console.WriteLine("Worker1 Dispatch Method");
        }
        public int GetworkerID()
        {
            return WorkerID;
        }
        public void SetworkerID(int WorkerId) 
        {
            Console.WriteLine("WorkerId"+ WorkerId);
        }


    }
}
/*Inherit from the Employee class and implement the IWorker interface.
In the Worker class, implement the abstract method DisplayDetails to display the details of the worker, including all properties.
Include an additional property in the Worker class: WorkerID(int).
Implement the methods from the IStudent interface.*/