namespace refandout
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = Math(100, 200);
            Console.WriteLine($"Result: {Result}");
            Console.ReadKey();
        }
        public static int Math(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}