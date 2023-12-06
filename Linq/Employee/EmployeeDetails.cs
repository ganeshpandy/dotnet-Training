using Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeDetails:Department
    {
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        //List<Employee> list = new List<Employee>();
        public void AddEmployee()
        {
            List<EmployeeDetails> employeelist = new List<EmployeeDetails>()
            {
            new EmployeeDetails() { DepartmentId = 1, EmployeeId=101, EmployeeName = "Alex",Age=30},
            new EmployeeDetails() { DepartmentId = 2, EmployeeId = 102, EmployeeName = "kamal", Age = 33 },
            new EmployeeDetails() { DepartmentId = 3, EmployeeId = 103, EmployeeName = "Kohil", Age = 35 },
            new EmployeeDetails() { DepartmentId = 4, EmployeeId = 104, EmployeeName = "Vijay", Age = 37 },
            new EmployeeDetails() { DepartmentId = 5, EmployeeId = 105, EmployeeName = "King", Age = 36 },
            new EmployeeDetails() { DepartmentId = 5, EmployeeId = 106, EmployeeName = "Joseph", Age = 34 },
            };
            List<Department> departmentlist = new List<Department>()
            {
            new Department() { DepartmentId = 1, DepartmentName = "HR"},
            new Department() { DepartmentId = 2, DepartmentName = "Finance"},
            new Department() { DepartmentId = 3, DepartmentName = "Techincal support"},
            new Department() { DepartmentId = 4, DepartmentName = "Testing"},
            new Department() { DepartmentId = 5, DepartmentName = "Development"},
            };

            /* var orderByAscending = from e in employeelist
                                    orderby e.EmployeeName
                                    select e;
             Console.WriteLine("OrderBy in Ascending order:");
             foreach (var employee in orderByAscending)
             {
                 Console.WriteLine($"{employee.EmployeeName} - {employee.Age}");
             }

             var orderByDescending = from e in employeelist
                                     orderby e.EmployeeName descending
                                     select e;
             Console.WriteLine("OrderBy in Descending order:");
             foreach (var employee in orderByDescending)
             {
                 Console.WriteLine($"{employee.EmployeeName} - {employee.Age}");
             }*/


            Console.WriteLine("ThenBy in Ascending order");
            var thenBy = employeelist.OrderBy(e => e.EmployeeName).ThenBy(e => e.Age);
            foreach (var employee in thenBy)
            {
                Console.WriteLine($"{employee.EmployeeName} - {employee.Age}");
            }

            var Where = from e in employeelist
                        where e.Age > 32 && e.Age < 40
                        select e.EmployeeName;
            Console.WriteLine("Where Condition");
            foreach (var employee in employeelist)
            {
                Console.WriteLine($"{employee.EmployeeName} - {employee.Age}");
            }




            Console.WriteLine("===================================");// //str1=emp,str2=dep     
            Console.WriteLine("innerJoin");
            var innerJoin = employeelist.Join(departmentlist,
                       emp => emp.DepartmentId,
                       dep => dep.DepartmentId,
                       (emp, dep) => new
                       {
                           EmployeeName = emp.EmployeeName,
                           DepartmentName = dep.DepartmentName
                       });
            foreach (var obj in innerJoin)
            {

                Console.WriteLine("{0} - {1}", obj.EmployeeName, obj.DepartmentName);
            }

            Console.WriteLine("===================================");
            Console.WriteLine("groupJoin");
            var groupJoin = from dep in departmentlist
                            join emp in employeelist
                            on dep.DepartmentId equals emp.DepartmentId
                                into EmployeeGroup
                            select new
                            {
                                EmployeeDetails = EmployeeGroup,
                                DepartmentName = dep.DepartmentName
                            };
            foreach (var item in groupJoin)
            {
                foreach (var data in item.EmployeeDetails)
                    Console.Write(data.EmployeeName+" -\t");               

                Console.Write(item.DepartmentName);
                Console.WriteLine();
            }

            /* Console.WriteLine("---------------------------------");
             Console.WriteLine("GroupBy");
             //var groupBy = employeelist.GroupBy(s => s.Age);//using method
               var groupBy = from e in employeelist
                             group e by e.Age;
               foreach (var ageGroup in groupBy)
               {
                   Console.WriteLine("Employee Age: {0}", ageGroup.Key);  
                   foreach (EmployeeDetails s in ageGroup) 
                       Console.WriteLine("Employee Name: {0}", s.EmployeeName);
               }*/


            /* Console.WriteLine("---------------------------------");
             Console.WriteLine("ToLookup");
             var lookup = employeelist.ToLookup(s => s.Age);

             foreach (var data in lookup)
             {
                 Console.WriteLine("Employee Age: {0}", data.Key);

                 foreach (EmployeeDetails e in data) 
                     Console.WriteLine("EmployeeName: {0}", e.EmployeeName);
             }*/

        }
    }
        
            
}
    

