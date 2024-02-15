public class Program
{
    public static void Main(string[] args)
    {
        int n = 5;
       for(int i=n; i<=n;i++) 
        {
           
            for (int j=0; j<=i;j--) 
            {
                Console.Write("* ");
            }
           Console.WriteLine();
        }
       Console.ReadKey();
    }
}