namespace PrimeNumber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n= Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int count = 0;
            while (a <= n / 2) { 
                if(n%2 == 0)
                {
                    count++;
                }
                a++;
            }
            if (count == 1)
            {
                Console.WriteLine(n + "is prime number");
            }
            else { 
            Console.WriteLine(n+"is not a prime number");
            }
        }
    }
}