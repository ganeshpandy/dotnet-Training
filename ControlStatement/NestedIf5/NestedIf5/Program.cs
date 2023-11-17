namespace NestedIf5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            if (n >= 0)
            {
                if (n < 0)
                {
                    Console.WriteLine("It is negative number");
                }
                else
                {
                    Console.WriteLine("It is positive number");
                }
            }
            else {
                Console.WriteLine("It is positive and whole number");
            }
        }
    }
}