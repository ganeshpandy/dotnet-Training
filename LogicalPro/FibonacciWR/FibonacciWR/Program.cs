namespace FibonacciWR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=5;
            int f1 = 0;
            int f2 = 1;
            int f3 = f1 + f2;
            while (n>0) {
                Console.WriteLine(f1);
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
                n--;
            }
        }
    }
}