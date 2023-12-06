using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicket
{
    internal class Booking
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
        public double Amount { get; set; }

        List<Booking> list = new List<Booking>();
        Booking book = null;
            public List<Booking> LoadDetails()
            {

                Booking book = new Booking();

                Console.WriteLine("Enter Ticket Id");
                book.Id = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter CustomerName");
                book.CustomerName = Console.ReadLine()!;

               /* Console.WriteLine("Enter Date");
                book.Date = DateTime.Now;*/

                Console.WriteLine("Enter Amount");
                book.Amount =double.Parse(Console.ReadLine()!);

                new Booking()
                {
                    Id = book.Id,
                    CustomerName = book.CustomerName,
                    Date = book.Date,
                    Amount = book.Amount,                
                };
                list.Add(book);
                return list;
            }
    }
}
