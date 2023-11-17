namespace NestedElse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Celsius: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp > 30)
            {
                Console.WriteLine("It's a hot day.");
            }
            else if (temp > 20)
            {
                Console.WriteLine("It's a pleasant day.");
            }
            else if (temp > 10)
            {
                Console.WriteLine("It's a cool day.");
            }
            else
            {
                Console.WriteLine("It's a cold day.");
            }
        }

    }
}
