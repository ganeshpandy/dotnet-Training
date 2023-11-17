namespace NestedIf4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int temp=Convert.ToInt32(Console.ReadLine());
            if (temp > 40)
            {
                if (temp > 36)
                {
                    Console.WriteLine("Fine weather");
                }
                else
                {
                    Console.WriteLine("Hot Weather");
                }
            }
            else {
                if (temp > =30)
                {
                    Console.WriteLine("Little bit cold");
                }
                else {
                    Console.WriteLine("extreme cold");
                }
            }
        }
    }
}