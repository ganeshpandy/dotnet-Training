namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myMethod(10);
        }
        static void myMethod(int n) { 
        if(n%2==0)
            {
                Console.WriteLine("Even Number");
            }
        else
            {
                Console.WriteLine("odd number");
            }
        }
    }
}