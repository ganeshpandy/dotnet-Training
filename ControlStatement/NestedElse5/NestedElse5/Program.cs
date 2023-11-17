namespace NestedElse5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Score 300");
            double runRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("current runrate");
            if (runRate > 6.0)
            {
                Console.WriteLine("target easly achievable");
            }
            else if (runRate > 5.5 && runRate < 6.0) {
                Console.WriteLine("still ok");
            }
            else if (runRate>5.0 && runRate<4.5) {
                Console.WriteLine("better score higher");
            }
            else {
                Console.WriteLine("u will lose the match");
            }

        }
    }
}