﻿namespace ArmstrongNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());//153
            string convert=n.ToString();
            int len = convert.Length;
            int temp = n;//153
            int res = 0;
            while (temp > 0)//15
            {
                int num = temp % 10;//3,5,1
                int cube = (int)Math.Pow(num,len); 
                res = res +cube;//0+27=27 27+125=152 152+1=153
                temp = temp / 10;//15,1
            }
            if (res == n)
            {
                Console.WriteLine(res + " Number is Armstrong number");
            }
            else
            {
                Console.WriteLine(res + " Number is not Armstrong number");
            }
        }
    }
}