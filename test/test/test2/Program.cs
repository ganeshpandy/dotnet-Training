namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 65; i <= 90; i++)
                Console.Write(" " + (char)i);
            Console.WriteLine();
            for (int i = 97; i <= 122; i++)
                Console.Write(" " + (char)i);
            Console.WriteLine();
            for (int i = 48; i <= 57; i++)
                Console.Write(" " + (char)i);
            Console.WriteLine();*/
            for (int i = 0; i <= 10; i++)
                Console.Write("{0} - {1} \t", i, (char)i);
            Console.WriteLine();
        }
    }
}