namespace p19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B");
            int b=Convert.ToInt32(Console.ReadLine());
            /*long a3 = Convert.ToInt64(Console.ReadLine());
            long b3=Convert.ToInt64(Console.ReadLine());
            double a4 = Convert.ToDouble(Console.ReadLine());
            double b4 = Convert.ToDouble(Console.ReadLine());
            */add(a, b);
            sub(a, b);
            mul(a, b);
            div(a, b);

        }
        static void add(int a, int b) { 
            int c = a + b;
            Console.WriteLine();
            Console.WriteLine("Add:"+c);
        }
        static void sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("sub:"+c);
        }
        static void mul(long a, long b)
        {
            long c = a * b;
            Console.WriteLine("mul:"+c);
        }
        static void div(double a, double b)
        {
            double c = a / b;
            Console.WriteLine("div:"+c);
        }

    }
}