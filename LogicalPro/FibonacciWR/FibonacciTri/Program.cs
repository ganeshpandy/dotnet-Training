namespace FibonacciTri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int n;
            Console.Write("Enter the number for FibonacciTri: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                a = 0;
                b = 1;
                Console.Write(b + "\t");
                for (int j = 1; j < i; j++)
                {
                    int c = a + b;
                    Console.Write(c + "\t");
                    a = b;
                    b = c;
                }
                Console.WriteLine();
            }
        }

    }
    }
