using System;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine("sum of digits are:" + sum);
        }
    }
    }
//