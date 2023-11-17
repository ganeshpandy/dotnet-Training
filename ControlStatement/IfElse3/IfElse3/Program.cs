namespace IfElse3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a=Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine(a+"is a positive number");
            else
                Console.WriteLine(a+"is not a positive number");
            Console.ReadKey();
        }
    }
}