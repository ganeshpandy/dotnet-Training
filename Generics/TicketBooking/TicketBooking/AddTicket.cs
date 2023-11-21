using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
     class AddTicket
    {
        public List<BusTicket> AddTicketList() 
        {
            /*Console.WriteLine("Enter the BusID:");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the PassengerName:");
            string Name=Console.ReadLine();

            Console.WriteLine("Enter ur StartingPoint:");
            string StartingPoint=Console.ReadLine();

            Console.WriteLine("Enter ur Destination:");
            string Destination = Console.ReadLine();

            Console.WriteLine("Enter ur Age:");
            int Age=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ur PhNo:");
            long PhNo=long.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter ur Gender:");
            string Gender=Console.ReadLine();

            Console.WriteLine("Enter  Date:");
            DateTime Date=DateTime.Now;*/

            List<BusTicket> list = new List<BusTicket>()
            {
                new BusTicket()
                {
                Id = 101,Name = "Vijay", StartingPoint = "Trichy",Gender="Male" ,Destination = "Chennai", Age = 21, PhNo = 1233456,Date = DateTime.Now
                }
            };
            return list;
        }
        public void DisplayBusTicket(List<BusTicket>ticket) 
        {
            foreach(var Data in ticket) 
            {
                Console.WriteLine("Bus ID            :" + Data.Id);
                Console.WriteLine("Passenger Name    :" + Data.Name);
                Console.WriteLine("StartingPoint     :" + Data.StartingPoint);
                Console.WriteLine("Destination       :" + Data.Destination);
                Console.WriteLine("Passenger Age     :" + Data.Age);
                Console.WriteLine("Passenger PhNo    :" + Data.PhNo);
                Console.WriteLine("Gender            :" + Data.Gender);
                Console.WriteLine("Date              :" + Data.Date);
            }
        }

    }
}
