namespace AlphaTri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';//b
            int n = 5;

            for (int i = 1; i <= n; i++)//outer
            {                   //  n=5   i=1    
                for (int j = 1; j <= n - i; j++)//1,2,3,4
                {// for space
                    Console.Write(" ");
                }                         
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(ch++);
                }                
                ch--;
                for (int j = 1; j < i; j++)
                {
                    Console.Write(--ch);
                }              
                Console.WriteLine();
            }

        }
    }
}

//   