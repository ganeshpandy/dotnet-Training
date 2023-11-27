using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking
{
    //ID,Name,StartingPoint,Destination,Age,Gender,PhNo,DateTime
    class SaveBooking : PassengerDetails, ITicket
    {
        List<PassengerDetails> list = new List<PassengerDetails>();
        PassengerDetails passenger = null, OldData = null;

        public List<PassengerDetails> Create()
        {
            PassengerDetails passenger = new PassengerDetails();

            Console.Write("Enter passenger ID : ");
            passenger.Id = int.Parse(Console.ReadLine()!);

            Console.Write("Enter passenger Name : ");
            passenger.Name = Console.ReadLine();

            Console.Write("Enter StartingPoint : ");
            passenger.StartingPoint = Console.ReadLine();

            Console.Write("Enter Destination : ");
            passenger.Destination = Console.ReadLine();

            Console.Write("Enter passenger Phone Number : ");
            passenger.PhNo = long.Parse(Console.ReadLine()!);

            Console.Write("Enter Date: ");
            passenger.Date = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Enter Age : ");
            passenger.Age = int.Parse(Console.ReadLine()!);

            //passengerDetails getpassenger = new passengerDetails
            passenger = new PassengerDetails()
            {
                Id = passenger.Id,
                Name = passenger.Name,
                Age = passenger.Age,                
                StartingPoint = passenger.StartingPoint,
                Destination = passenger.Destination,
                PhNo = passenger.PhNo,
                Date = passenger.Date,                
            };
            list.Add(passenger);
            Console.WriteLine("passenger Ticket created!");
            return list;
        }

        public void Read()
        {
            if (list.Count > 0)
            {
                foreach (var company in list)
                {
                    Console.WriteLine("passenger Id             : " + passenger.Id);
                    Console.WriteLine("passenger Name           : " + passenger.Name);
                    Console.WriteLine("passenger Age            : " + passenger.Age);
                    Console.WriteLine("passenger StartingPoint  : " + passenger.StartingPoint);
                    Console.WriteLine("Destination              : " + passenger.Destination);
                    Console.WriteLine("Phone Number             : " + passenger.PhNo);
                    Console.WriteLine("Date                     : " + passenger.Date);
                    
                }
            }
            else
            {
                Console.WriteLine("passenger not found!");
            }

        }
        public void Delete()
        {
            if (list.Count > 0)
            {
                list.Clear();
                Console.WriteLine("All records deleted!");
            }
            else
            {
                Console.WriteLine("No records found!");
            }
        }



        public void Update()
        {
            Console.Write("Enter passenger ID to update: ");
            int UpdateEmp = int.Parse(Console.ReadLine()!);
            foreach (var data in list)
            {
                if (data.Id == UpdateEmp)
                {
                    OldData = data;
                    break;
                }
            }
            //ID,Name,StartingPoint,Destination,Age,Gender,PhNo,DateTime
            Console.WriteLine("Enter new the Id");
            passenger.Id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter new the Name");
            passenger.Name = Console.ReadLine();

            Console.WriteLine("Enter new the StartingPoint");
            passenger.StartingPoint = Console.ReadLine();

            Console.WriteLine("Enter new the Destination");
            passenger.Destination = Console.ReadLine();
            
            Console.WriteLine("Enter the PhoneNo");
            passenger.PhNo = long.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter new the Age");
            passenger.Age = int.Parse(Console.ReadLine()!);

            Console.Write("Enter New passenger Date: ");
            passenger.Date = DateTime.Parse(Console.ReadLine()!);

            
        }

    }
}
