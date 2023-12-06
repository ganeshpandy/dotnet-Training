namespace MovieTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Booking booking = new Booking();
            List<Booking> book = booking.LoadDetails();

            Console.WriteLine("Enter the Id to search:");
            int FindId = int.Parse(Console.ReadLine()!);

            var Selected = from data in book
                           where data.Id == FindId
                           select data;
            foreach (var item in Selected)
            {
                Console.WriteLine($"TicketId:{item.Id}\nCustomerName: {item.CustomerName}\n" +
                    $"Date: {item.Date}\nAmount:{item.Amount}");
            }
            var orderdata = from data in book
                           orderby data.Id
                           select data;
            foreach (var item in orderdata)
            {
                Console.WriteLine($"TicketId:{item.Id}\nCustomerName: {item.CustomerName}\n" +
                    $"Date: {item.Date}\nAmount:{item.Amount}");
            }
        }
    }
}
