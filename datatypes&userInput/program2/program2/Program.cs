using System.Xml.Linq;

namespace program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ur ID:");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ur Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ur Address:");
            string address=Console.ReadLine();
            Console.WriteLine("Enter Your Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter ur DOB:");
            string dob = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Employee details");
            Console.WriteLine("ID:" +id+ "\n" + "Age" + age + "\n" + "Address:" + address + "\n" + "Email:" + email + "\n" + "DOB:" +dob);
        }
    }
}