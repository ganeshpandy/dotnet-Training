namespace Nestedif2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            int len = password.Length;
            if (len >= 8)
            {
                if (len >= 5)
                {
                    Console.WriteLine("Average password");
                }
                else
                {
                    Console.WriteLine("good password");
                }
            }
            else
            {
                if (len >= 6)
                {
                    Console.WriteLine("Good password");
                }
                else {
                    Console.WriteLine("Good password");
                }
            }
        }
    }
}