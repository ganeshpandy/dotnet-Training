namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            num.PrimeOrNot();

        }
    }
    static class PrimeNo 
    {
        public static int PrimeOrNot(this int num) 
        {
            int a = 1;
            int count = 0;
            while (a <= num / 2)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
                a++;
            }
            if (count == 1)
            {
                Console.WriteLine(num + "is prime number");
            }
            else
            {
                Console.WriteLine(num + "is not a prime number");
            }

            return count;
        }
    }
}
