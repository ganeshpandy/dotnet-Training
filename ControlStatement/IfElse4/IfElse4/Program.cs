namespace IfElse4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("A is greater than B");
            }
            else
            {
                Console.WriteLine("B is greater than C");
            }
            Console.ReadKey();
        }
    }
}