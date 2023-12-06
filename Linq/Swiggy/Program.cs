namespace Swiggy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order ordering = new Order();
            List<Order> order = ordering.LoadDetails();

            Console.WriteLine("Enter the Id to search:");
            int FindId = int.Parse(Console.ReadLine()!);

            var Selected = from data in order
                           where data.Id == FindId
                           select data;
            ordering.OrderList();
            foreach (var item in Selected)
            {
                Console.WriteLine($"OrderId:{item.Id}\nCustomerName: {item.Name}\n" +
                    $"HotelName: {item.HotelName}\nAmount:{item.Amount}");
            }
            ordering.OrderList();
        }
    }
}
