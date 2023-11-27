using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
     interface ITicket
    {
        List<PassengerDetails> Create();
        void Update();
        void Delete();
        void Read();
    }
}
