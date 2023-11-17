namespace NumberTri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, j, k;
            for (i = 1; i <= 6; i++)
            {                
                for (j = 6; j > i; j--)
                {
                    Console.Write(" ");
                }             
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }                
                for (k = i - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }                
                Console.WriteLine();
            }
        }
        }
    }
}