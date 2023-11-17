namespace NestedElse4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("distinction");
            }
            else if (score >= 80)
            {
                Console.WriteLine("I class");
            }
            else if (score >= 70)
            {
                Console.WriteLine("II class");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Third class");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

    }
}