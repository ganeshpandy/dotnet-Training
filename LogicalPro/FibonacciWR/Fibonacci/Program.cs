namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Fibonacci series");
            fibo(0,1,1,10);            
        }
       public static void fibo(int f1,int f2,int i,int n ){

            if (i <= n) {
                Console.WriteLine(" " + f1);
                int f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                i++;
                fibo(f1,f2,i,n);
            }
        }
    }
}