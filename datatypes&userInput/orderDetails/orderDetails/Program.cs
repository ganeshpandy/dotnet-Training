namespace orderDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Name:");
            string mobileName=Console.ReadLine();
            Console.WriteLine("Product Model:");
            string proId=Console.ReadLine();
            Console.WriteLine("Product price:");
            int price=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("order details");
            Console.WriteLine("Product Name:"+mobileName+"\n"+"Product model" +proId+"\n"+"Product Price:"+price);
        }
    }
}