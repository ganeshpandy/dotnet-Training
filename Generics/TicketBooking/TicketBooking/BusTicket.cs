using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
     class BusTicket
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? StartingPoint { get; set; }
        public string? Destination { get; set;}
        public int Age { get; set; }
        public string Gender {  get; set; }
        public long PhNo {  get; set; }
        public DateTime Date { get; set; }= DateTime.Now;

    }
}
