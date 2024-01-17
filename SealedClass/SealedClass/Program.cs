using System.ComponentModel;
using System.Net;
using System.Security.Cryptography;

namespace SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetEmployeeData();//extension method
            employee.DisplayEmployeeData();

        }
    }
    public sealed class Employee
    {
        public int EId, EAge;
        public string EName, EAddress;

        public void DisplayEmployeeData()
        {
            Console.WriteLine("\nEmplpyee Details Are:");
            Console.WriteLine($"Employee ID: {EId}");
            Console.WriteLine($"Employee Name: {EName}");
            Console.WriteLine($"Employee Address: {EAddress}");
            Console.WriteLine($"Employee Age: {EAge}");
        }
    }
    //public class Manager : Employee { }
    //No Inheritance is Possible as we marked the class as sealed
    public static class Details
    {
        public static void GetEmployeeData(this Employee employee)
        {
            Console.WriteLine("Enter Employee Details:");
            Console.Write("Enter Employee ID:");
            employee.EId = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name:");
            employee.EName = Console.ReadLine();
            Console.Write("Enter Employee Address:");
            employee.EAddress = Console.ReadLine();
            Console.Write("Enter Employee Age:");
            employee.EAge = int.Parse(Console.ReadLine());
        }
    }
}
