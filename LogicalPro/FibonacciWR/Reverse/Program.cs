using System.Text;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while (num > 0)//123,12,1
            {
                int rem = num % 10;//3,  2, 1
                rev = rev * 10 + rem;//0*10+3=3, 3*10+2=32, 32*10+1=321    
                num = num / 10;//12 1
            }
            Console.WriteLine("Reverse of :"+rev);
        }
    }
}
//123/10=3
