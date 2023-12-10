namespace Delegate
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            List<Employee> employees = employee.Create();
            IncrementSalary incrementSalary = new IncrementSalary(employee.SalaryIncrement);
            incrementSalary(employees, 2000);
            
              
                    
            //employee.SalaryIncrement(employees);

        }
    }
}
