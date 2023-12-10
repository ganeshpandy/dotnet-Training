using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void IncrementSalary(List<Employee> employeeList,double bonus);
    public class Employee
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public int Exp {  get; set; }
        

        public List<Employee> Create()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { Id = 101, Name = "Stark", Position = "Tester", Salary = 15000, Exp = 1 });
            employeeList.Add(new Employee() { Id = 102, Name = "Thor", Position = "Admin", Salary = 13000, Exp = 3 });
            employeeList.Add(new Employee() { Id = 103, Name = "Steve", Position = "Technical Support", Salary = 12500, Exp = 4 });
            employeeList.Add(new Employee() { Id = 104, Name = "Edwin", Position = "HR", Salary = 17000, Exp = 5 });
            employeeList.Add(new Employee() { Id = 105, Name = "Arwin", Position = "UI Developer", Salary = 17000, Exp = 6 });

            return employeeList;
        }

        public void SalaryIncrement(List<Employee> employeeList,double bonus)
        {
            foreach (Employee emp in employeeList)
            {
                if (emp.Exp >= 2)
                {
                    
                    emp.Salary =emp.Salary+bonus;
                    Console.WriteLine($"{emp.Name}'s new salary: {emp.Salary}");
                }
            }
        }



    }
}
