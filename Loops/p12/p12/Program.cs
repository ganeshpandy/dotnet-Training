namespace p12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Age");
            int age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Address");
            string address= Console.ReadLine();
            Console.WriteLine("Enter Your Email");
            string email= Console.ReadLine();
            Console.WriteLine("Enter Your dob");
            string dob= Console.ReadLine();
            empDetails(id, age, address, email, dob);
        }
        static void empDetails(int id,int age,string address,string email,string dob) {
            Console.WriteLine("Your ID is:" + id);
            Console.WriteLine("Your AGE is:" + age);
            Console.WriteLine("Your ADDRESS is:" + address);
            Console.WriteLine("Your EMAIL is:" + email);
            Console.WriteLine("Your DOB is:" + dob);
        }
    }
}