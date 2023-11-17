namespace IfElse5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n % 2 != 0)
                Console.WriteLine(n + "is a odd number");
            else
                Console.WriteLine(n+"is not a odd number");
            Console.ReadKey();
        }
    }
}