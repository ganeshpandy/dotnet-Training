using System.Xml.Linq;

namespace IRCTC
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string? Name = Console.ReadLine();

            Console.WriteLine("Enter Customer TicketId");
            string? TicketId = Console.ReadLine();

            Console.WriteLine("Enter Date");
            string? Date = Console.ReadLine();

            Console.WriteLine("Price");
            double Price=double.Parse(Console.ReadLine());

            //object
            Booking booking=new Booking(Name,TicketId,Date,Price);
            string FilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\IRCTC\\Booking\\Booking.txt";

            //FileStream f = System.IO.File.Create(FilePath);
            string BookingData = "Name:" + booking.Name + "\n TicketId:" + booking.TicketId +
               "\n Date:" + booking.Date + "\n Price:" + booking.Price;

            System.IO.File.WriteAllText(FilePath, BookingData);
            Console.WriteLine("Data Created:\n" + BookingData);
        }
        
    }
}