namespace p20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter Employee ID:");
            int id=Convert.ToInt32(Console.ReadLine());
            */Console.WriteLine("Enter Employee Name:");
            string empName=Console.ReadLine();
            Console.WriteLine("Enter Employee Email");
            string empEmail=Console.ReadLine();
            Console.WriteLine("Enter Employee Address");
            string empAddress=Console.ReadLine();
            Console.WriteLine("Employee salary");
            long salary=Convert.ToInt64(Console.ReadLine());
            emp(empName, empEmail, empAddress,salary);
        }
        static void emp(string empName,string empEmail,string empAddress,long salary, int id = 101)
        {
            Console.WriteLine("Employee ID:" + id);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Employee Email:" + empEmail);
            Console.WriteLine("Employee empAddress:" + empAddress);
            Console.WriteLine("Employee Salary:" + salary);
        }
    }
}