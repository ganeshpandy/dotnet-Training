namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the First Number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swaping:" + n1 + " " + n2);
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;

            Console.WriteLine("After swaping:" + n1 + " " + n2);
        }
    }
}