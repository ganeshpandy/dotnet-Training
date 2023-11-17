namespace Logical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine(a>b && a==b);
            Console.WriteLine(a<=b ||a!=b);
            Console.WriteLine(!(a==b));
        }
    }
}