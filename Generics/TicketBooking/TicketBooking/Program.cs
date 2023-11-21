namespace TicketBooking
{
     class Program
    {
        static void Main(string[] args)
        {
            AddTicket addTicket = new AddTicket();
            List<BusTicket>listobj = addTicket.AddTicketList();
            addTicket.DisplayBusTicket(listobj);

        }
    }
}