namespace Constructor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeeObj=new Employee("SIS");
            Employee e2 = new Employee(101,"alex",500000);

            //employeeObj.read();            
        }
    }
    class Employee {
        string companyName;
        public Employee(string companyName)
        {
            //this.companyName = companyName;
            Console.WriteLine("Company Name:"+companyName);
        }
        public Employee(int id, string empName,double salary) { 
            Console.WriteLine("Employee ID:"+id);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Employee Salary:" + salary);
        }
        /*public void read() {
            Console.WriteLine(companyName);
        }*/
    }
}