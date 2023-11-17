namespace FoodMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Food Item:");
            string foodName = Console.ReadLine();
            Console.WriteLine("Customer Name:");
            string cusName = Console.ReadLine();
            Console.WriteLine("Price:");
            double price=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("FoodMenu");
            Console.WriteLine("Food Name:" + foodName + "\n"+"Customer Name:"+cusName+"\n"+"price:"+price);

        }
    }
}