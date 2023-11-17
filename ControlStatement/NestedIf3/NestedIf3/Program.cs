namespace NestedIf3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mark");
            int mark=Convert.ToInt32(Console.ReadLine());
            if (mark >= 40)
            {
                if (mark > 60)
                {
                    Console.WriteLine("Good Mark");
                }
                else
                {
                    Console.WriteLine("Average mark");
                }
            }
           
        }
    }
}