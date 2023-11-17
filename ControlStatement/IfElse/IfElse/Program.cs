namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Check 
            Console.WriteLine("Enter ur age");
            int age=Convert.ToInt16(Console.ReadLine());
            if (age >= 18 ) {
                Console.WriteLine("eligiable for vote");
            }
            else 
            {
                Console.WriteLine("Not eligiable for vote");
            }
            Console.ReadKey();
        }
    }
}