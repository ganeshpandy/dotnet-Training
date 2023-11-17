namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            Console.WriteLine("Enter the Nth number");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("prime number between 1 to " + n + " are :");
            for (int i = 2; i <= n; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if ( i% j == 0)
                    {
                        count++;
                    }   
                }
                if (count == 2)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}