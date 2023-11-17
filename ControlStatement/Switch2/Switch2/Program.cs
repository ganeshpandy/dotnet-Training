namespace Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month=Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("january");
                    break;
                case 2:
                    Console.WriteLine("febuary");
                    break;
                case 3:
                    Console.WriteLine("march");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("may");
                    break;
                case 6:
                    Console.WriteLine("june");
                    break;
                case 7:
                    Console.WriteLine("july");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("september");
                    break;
                case 10:
                    Console.WriteLine("october");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
        }
    }
}