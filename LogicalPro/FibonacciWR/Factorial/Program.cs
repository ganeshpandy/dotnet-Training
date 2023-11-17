namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());//5,4
            int fact = 1;//5,20,60
            while (n>0) {//5,4,3,2
                fact=fact*n;//1*5=5 5*4=20 20*3=60 60*2=120   
                n--;
            }

            /*while (n > 0) {
                fact=fact*n;
                n--;
            }*/
            Console.WriteLine(fact);
        }
    }
}
//