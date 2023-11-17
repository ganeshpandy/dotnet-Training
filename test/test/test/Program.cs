namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Number From " + i + " to " + n + " are Even number");
                }
            }
            Console.WriteLine("While Loop");
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n + " is a even number");
                }
                n--;
            }
            Console.WriteLine("Dowhile loop");
            int a = 1;
            do {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a + "is even");                   
                }
                a++;
            } while (a <= n);
        }
    }
}