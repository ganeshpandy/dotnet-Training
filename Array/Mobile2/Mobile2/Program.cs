using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace Mobile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]names = { "SamsungM31", "Nokia1100", "Redmi12", "LenovoA31", "Nothing1", "Iphone6", "LavaAgni2" };
            Console.WriteLine("Enter the mobilename:");
            string mobilename=Console.ReadLine();
            int i;
            for (i = 0; i < names.Length; i++)
            {
                if (mobilename.Equals(names[i].ToLower()))
                {
                    break;
                }
            }
            switch (i) {
                case 0:
                    Console.WriteLine("SamsungM31 price is 32k");
                    break;
                case 1:
                    Console.WriteLine("Nokia1100 price is 5k");
                    break;
                case 2:
                    Console.WriteLine("Redmi12 price is 15k");
                    break;
                case 3:
                    Console.WriteLine("LenovoA31 price is 17k");
                    break;
                case 4:
                    Console.WriteLine("Nothing1 price is 14k");
                    break;
                case 5:
                    Console.WriteLine("Iphone6 price is 1L");
                    break;
                case 6:
                    Console.WriteLine("LavaAgni2 price is 10k");
                    break;
                    default:
                    Console.WriteLine("Invalid option");
                    break;


            }

        }
    }
}