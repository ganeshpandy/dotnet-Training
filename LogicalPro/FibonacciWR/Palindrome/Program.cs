using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n=Convert.ToInt32(Console.ReadLine());
            int org = n; ;
            int rev = 0;
            while (n > 0)//1
            {
                int last = n % 10;                
                n = n / 10;
                rev = rev * 10 + last;
            }
            if (org == rev)
               Console.WriteLine(rev + " is a palindrome number");

            else
                Console.WriteLine(rev + "is not a palindrome number");

        }
    }
}
