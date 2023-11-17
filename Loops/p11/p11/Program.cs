namespace p11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the UserName");
            string userName=Console.ReadLine();
            Console.WriteLine("Enter the password");
            string password=Console.ReadLine();
            details(userName,password);
        }
        static void details(string userName,string password) {
            Console.WriteLine("Your UserName:"+userName);
            Console.WriteLine("Your password:" + password);
        }
    }
}