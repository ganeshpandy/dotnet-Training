namespace Nestedelse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height: ");
            double height = double.Parse(Console.ReadLine());
            double measure = weight / height;

            if (measure < 50.55)
            {
                Console.WriteLine("Underweight");
            }
            else if (measure >= 60.56 && measure < 75.34)
            {
                Console.WriteLine("Normal weight");
            }
            else if (measure >= 75.34 && measure < 90.9)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }
        }


    }
}
