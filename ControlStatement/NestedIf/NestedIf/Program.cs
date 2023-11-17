namespace NestedIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1800;
            int b = 300;
            int c = 100;
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("A is greater than C and B");
                }
                else {
                    Console.WriteLine("C is greater than A and B");
                }
            
            }
            else  {
                if (b > c)
                {
                    Console.WriteLine("B is greater than A and C");
                }
                else 
                {
                    Console.WriteLine("C is greater than A and B");
                }
            }
            Console.ReadKey();
        }
    }
}