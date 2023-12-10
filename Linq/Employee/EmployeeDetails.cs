using Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeDetails:Department
    {
        //public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public static List<EmployeeDetails>LoadEmployee()
        {
            List<EmployeeDetails> employeelist = new List<EmployeeDetails>()
            {
            new EmployeeDetails() { DepartmentId = 1, EmployeeId=101, EmployeeName = "Alex",Age=30},
            new EmployeeDetails() { DepartmentId = 2, EmployeeId = 102, EmployeeName = "kamal", Age = 33 },
            new EmployeeDetails() { DepartmentId = 3, EmployeeId = 103, EmployeeName = "Kohil", Age = 35 },
            new EmployeeDetails() { DepartmentId = 4, EmployeeId = 104, EmployeeName = "Vijay", Age = 37 },
            new EmployeeDetails() { DepartmentId = 5, EmployeeId = 105, EmployeeName = "King", Age = 36 },
            new EmployeeDetails() { DepartmentId = 5, EmployeeId = 106, EmployeeName = "Joseph", Age = 34 },
            new EmployeeDetails() { DepartmentId = 10, EmployeeId = 0, EmployeeName = "Vijay", Age = 34 },
            new EmployeeDetails() { DepartmentId = 11, EmployeeId = 0, EmployeeName = "John", Age = 34 },
            };
            return employeelist;
        }
        public static List<Department> LoadDepartment() 
        {
            List<Department> departmentlist = new List<Department>()
            {
            new Department() { DepartmentId = 1, DepartmentName = "HR"},
            new Department() { DepartmentId = 2, DepartmentName = "Finance"},
            new Department() { DepartmentId = 3, DepartmentName = "Techincal support"},
            new Department() { DepartmentId = 4, DepartmentName = "Testing"},
            new Department() { DepartmentId = 5, DepartmentName = "Development"},
            new Department() { DepartmentId = 6, DepartmentName = "QBA"},
            };
            return departmentlist;
        }
        public static List<Company> LoadCompany() 
        {
            List<Company> companylist = new List<Company>()
            {
            new Company() { DepartmentId = 1, CompanyName = "SISDSS",CompanyAddress="Polland"},
            new Company() { DepartmentId = 2, CompanyName = "SISDSS",CompanyAddress = "USA"},
            new Company() { DepartmentId = 3, CompanyName = "SISDSS",CompanyAddress="India"},
            new Company() { DepartmentId = 4, CompanyName = "SISDSS",CompanyAddress= "India"},
            new Company() { DepartmentId = 5, CompanyName = "SISDSS",CompanyAddress= "Canada"},
            };
            return companylist;
        }
        public void SortingOperation(List<EmployeeDetails>employeelist,List<Department>departmentlist,List<Company>companylist) 
        {
            Console.WriteLine("===============OrderByAscending====================");
            var orderByAscending = from e in employeelist
                                   orderby e.EmployeeName
                                   select e;            
            foreach (var employee in orderByAscending)
            {
                Console.WriteLine($"{employee.EmployeeName} - {employee.Age}");
            }
            Console.WriteLine();

            Console.WriteLine("==============OrderByDescending=====================");             
            var orderByDescending = from e in employeelist
                                    orderby e.EmployeeName descending
                                    select e;            
            foreach (var employee in orderByDescending)
            {
                Console.WriteLine($"{employee.EmployeeName} - {employee.Age}");
            }
            Console.WriteLine();

            Console.WriteLine("==============ThenByAscending======================");            
            var thenBy = orderByAscending.ThenBy(e => e.Age);
            foreach (var employee in thenBy)
            {
                Console.WriteLine($"{employee.EmployeeName} - {employee.Age}");
            }
            Console.WriteLine();

            Console.WriteLine("==============ThenByDescending======================");
            var thenByDesc = orderByAscending.ThenByDescending(e => e.Age);
            foreach (var employee in thenBy)
            {
                Console.WriteLine($"{employee.EmployeeName} - {employee.Age}");
            }
            Console.WriteLine();
        }
        public void Join(List<EmployeeDetails> employeelist, List<Department> departmentlist, List<Company> companylist)
        {

            Console.WriteLine("=============InnerJoin=================");
            var innerJoin = from emp in employeelist
                                 join dep in departmentlist on emp.DepartmentId equals dep.DepartmentId
                                 select new
                                 {
                                     EmployeeName = emp.EmployeeName,
                                     DepartmentName = dep.DepartmentName
                                 };
            foreach (var obj in innerJoin)
            {

                Console.WriteLine("{0} - {1}", obj.EmployeeName, obj.DepartmentName);
            }
            Console.WriteLine() ;


            Console.WriteLine("===========3InnerJoin================");
            var innerJoin2 = from emp in employeelist
                        join dep in departmentlist on emp.DepartmentId equals dep.DepartmentId
                        join com in companylist on dep.DepartmentId equals com.DepartmentId
                        select new
                        {
                            emp.EmployeeName,
                            dep.DepartmentId,
                            dep.DepartmentName,
                            com.CompanyName,
                            com.CompanyAddress
                        };
            foreach (var result in innerJoin2)
            {
                Console.WriteLine($"Employee: {result.EmployeeName}, Department: {result.DepartmentName}," +
                    $" Company: {result.CompanyName},Address:{result.CompanyAddress}");
            }
            Console.WriteLine();

            Console.WriteLine("==============LeftJoin==================");
            var leftJoin = from emp in employeelist
                           join dep in departmentlist
                           on emp.DepartmentId equals dep.DepartmentId into EmployeeGroup
                           from p in EmployeeGroup.DefaultIfEmpty()
                           select new
                           {
                               EmployeeDetails = emp.EmployeeName,
                               DepartmentName = p != null ? p.DepartmentName : "Null" // Handle null case
                           };

            foreach (var result in leftJoin)
            {
                Console.WriteLine($"Employee: {result.EmployeeDetails}, Department: {result.DepartmentName}");
            }
            Console.WriteLine() ;

            Console.WriteLine("==============3LeftJoin=====================");            
            var leftJoinQuery = from emp in employeelist
                                join dep in departmentlist on emp.DepartmentId equals dep.DepartmentId into depGroup
                                from dep in depGroup.DefaultIfEmpty()
                                join com in companylist on emp.DepartmentId equals com.DepartmentId into comGroup
                                from com in comGroup.DefaultIfEmpty()
                                select new
                                {
                                    EmployeeDetails = emp.EmployeeName,
                                    DepartmentName = dep != null ? dep.DepartmentName : "Null",
                                    CompanyName = com != null ? com.CompanyName : "Null"
                                };

            foreach (var result in leftJoinQuery)
            {
                Console.WriteLine($"Employee: {result.EmployeeDetails}, Department: {result.DepartmentName}, Company: {result.CompanyName}");
            }
            Console.WriteLine();

            Console.WriteLine("=================Rightjoin=======================");            
            var rightJoin = from dep in departmentlist
                            join emp in employeelist
                            on dep.DepartmentId equals emp.DepartmentId into EmployeeGroup
                            from e in EmployeeGroup.DefaultIfEmpty()
                            select new
                            {
                                EmployeeDetails = e != null ? e.EmployeeName : "Null",
                                DepartmentName = dep.DepartmentName
                            };

            foreach (var result in rightJoin)
            {
                Console.WriteLine($"Employee: {result.EmployeeDetails}, Department: {result.DepartmentName}");
            }
            Console.WriteLine();

            Console.WriteLine("================GroupJoin======================");            
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
                    Console.Write(data.EmployeeName + " -\t");

                Console.Write(item.DepartmentName+ "-\t");                
            }
            Console.WriteLine();

            Console.WriteLine("================FullOuterJoin======================");
            var fullOuterJoin = leftJoin.Union(rightJoin);
            foreach (var result in fullOuterJoin)
            {
                Console.WriteLine($"Employee: {result.EmployeeDetails}, Department: {result.DepartmentName}");
            }
            Console.WriteLine();

            Console.WriteLine("================CrossJoin======================");
            var crossJoin= from emp in employeelist
                           from dep in departmentlist
                           select new
                           {
                               EmployeeDetails = emp.EmployeeName,
                               DepartmentName = dep.DepartmentName
                           };
            foreach (var result in crossJoin)
            {
                Console.WriteLine($"Employee: {result.EmployeeDetails}, Department: {result.DepartmentName}");
            }
            Console.WriteLine();
        }
        public void GroupOperation(List<EmployeeDetails> employeelist, List<Department> departmentlist, List<Company> companylist)
        {
            Console.WriteLine("==================GroupBy===========================");            
            //var groupBy = employeelist.GroupBy(s => s.Age);//using method
            var groupBy = from e in employeelist
                          group e by e.Age;
            foreach (var ageGroup in groupBy)
            {
                Console.WriteLine("Employee Age: {0}", ageGroup.Key);
                foreach (EmployeeDetails s in ageGroup)
                    Console.WriteLine("Employee Name: {0}", s.EmployeeName);
            }
            Console.WriteLine();


            Console.WriteLine("==================ToLookup===========================");            
            var lookup = employeelist.ToLookup(s => s.Age);

            foreach (var data in lookup)
            {
                Console.WriteLine("Employee Age: {0}", data.Key);

                foreach (EmployeeDetails e in data)
                    Console.WriteLine("EmployeeName: {0}", e.EmployeeName);
            }
            Console.WriteLine();
        }
        public void FilteringOperation(List<EmployeeDetails> employeelist, List<Department> departmentlist, List<Company> companylist)
        {
            Console.WriteLine("================Where Condition========================");            
            var Where = from e in employeelist
                        where e.Age > 32 && e.Age < 40
                        select e.EmployeeName;

            foreach (var employee in employeelist)
            {
                Console.WriteLine($"{employee.EmployeeName} - {employee.Age}");
            }
        }
        public void ProjectionOperation(List<EmployeeDetails> employeelist, List<Department> departmentlist, List<Company> companylist)
        {
            Console.WriteLine("================Select Condition========================");
            var select = from item in employeelist
                         select item.EmployeeName;
            foreach (var item in employeelist)
            {
                Console.WriteLine($"{item.EmployeeName} - {item.Age}");
            }
            Console.WriteLine();

            Console.WriteLine("================SelectMany Condition=====================");
            var selectMany = employeelist.SelectMany(employee => employee.EmployeeName);
            foreach (var item in employeelist)
            {
                Console.WriteLine($"{item.EmployeeName} - {item.Age}");
            }
        }

        public void AggregateOperation(List<EmployeeDetails> employeelist)
        {
            Console.WriteLine("================AggregateOperation========================");
            var sumofage = employeelist.Sum(employee => employee.Age);
            Console.WriteLine($"Sum of Employee's Age:{sumofage}");
            Console.WriteLine();

            var count = employeelist.Count();
            Console.WriteLine("How many employees are their in the company: " + count);
            Console.WriteLine();

            var avg = employeelist.Average(employee => employee.Age);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine();

            var min=employeelist.Min(employee => employee.Age);
            Console.WriteLine($"EmployeeName:   {EmployeeName}\t EmployeeAge:   {min}");
            Console.WriteLine();

            var max=employeelist.Max(employee => employee.Age);
            Console.WriteLine($"EmployeeName:   {EmployeeName}\t EmployeeAge:   {max}");
            Console.WriteLine();
        }
        public void PartitionOperation(List<EmployeeDetails> employeelist) 
        {
            Console.WriteLine("================PartitionOperation========================");
            var take = employeelist.Take(4);            
            foreach (var str in take)
                Console.WriteLine($"Employee: {str.EmployeeName}, EmployeeId: {str.DepartmentId}");
            Console.WriteLine();

            var takeWhile = employeelist.TakeWhile(employee => employee.Age < 35);
            foreach (var str in takeWhile)
                Console.WriteLine($"Employee: {str.EmployeeName}, EmployeeAge: {str.Age}");
            Console.WriteLine();

            var skipQuery = employeelist.Skip(3);
            foreach (var str in skipQuery)
                Console.WriteLine($"Employee: {str.EmployeeName}, EmployeeAge: {str.Age}");
            Console.WriteLine();

            var skipWhile = employeelist.SkipWhile(emp => emp.Age < 30);
            foreach (var str in skipWhile)
                Console.WriteLine($"Employee: {str.EmployeeName}, EmployeeAge: {str.Age}");
            Console.WriteLine();
        }




    }
        
            
}
    

