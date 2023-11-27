using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
     class SavePassenger:PassengerDetail
    {
        List<PassengerDetail> list = new List<PassengerDetail>();
        PassengerDetail passenger = null, OldData = null;
        //Id,Name,Arrival,Departure,Age,Gender,Phno,Date
        public List<PassengerDetail> Create()
        {
            PassengerDetail passenger = new PassengerDetail();

            Console.Write("Enter passenger ID : ");
            passenger.Id = int.Parse(Console.ReadLine()!);

            Console.Write("Enter passenger Name : ");
            passenger.Name = Console.ReadLine();

            Console.Write("Enter passenger Arrival : ");
            passenger.Arrival = Console.ReadLine();

            Console.Write("Enter passenger Departure : ");
            passenger.Departure = Console.ReadLine();

            Console.Write("Enter Age : ");
            passenger.Age = int.Parse(Console.ReadLine()!);


            Console.Write("Enter passenger Phone Number : ");
            passenger.PhNo = long.Parse(Console.ReadLine()!);

            Console.Write("Enter passenger Date of Boarding : ");
            passenger.Date = DateTime.Parse(Console.ReadLine()!);

            //Id,Name,Arrival,Departure,Age,Gender,PhNo,Date

            passenger = new PassengerDetail()
            {
                Id = passenger.Id,
                Name = passenger.Name,
                Age = passenger.Age,
                Arrival = passenger.Arrival,
                Departure = passenger.Departure,
                PhNo = passenger.PhNo,
                Date = passenger.Date,                
            };
            list.Add(passenger);
            Console.WriteLine("passenger details created!");
            return list;
        }
        //Id,Name,Arrival,Departure,Age,Gender,PhNo,Date
        public void Read()
        {
            if (list.Count > 0)
            {
                foreach (var data in list)
                {
                    Console.WriteLine("passenger Id        : " + data.Id);
                    Console.WriteLine("passenger Name      : " + data.Name);
                    Console.WriteLine("Age                 : " + data.Age);
                    Console.WriteLine("passenger Address   : " + data.Arrival);
                    Console.WriteLine("passenger Email     : " + data.Departure);
                    Console.WriteLine("Phone Number        : " + data.PhNo);
                    Console.WriteLine("Date Of Boarding       : " + data.Date);                    
                }
            }
            else
            {
                Console.WriteLine("passenger not found!");
            }
        }

        //Id,Name,Arrival,Departure,Age,Gender,PhNo,Date
        public void Update()
        {
            Console.Write("Enter  ID to update: ");
            int UpdatePass = int.Parse(Console.ReadLine()!);
            foreach (var data in list)
            {
                if (data.Id == UpdatePass)
                {
                    OldData = data;
                    break;
                }
            }
            Console.WriteLine("Enter the Id");
            passenger.Id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the Name");
            passenger.Name = Console.ReadLine();

            Console.WriteLine("Enter the Age");
            passenger.Age = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter new the Arrival");
            passenger.Arrival = Console.ReadLine();

            Console.WriteLine("Enter the Departure");
            passenger.Departure = Console.ReadLine();

            Console.Write("Enter New Employee Date Of Boarding : ");
            passenger.Date = DateTime.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the PhoneNo");
            passenger.PhNo = long.Parse(Console.ReadLine()!);            
        }
        public void Delete()
        {
            if (true)
            {
                list.Clear();
                Console.WriteLine("All records deleted!");
            }
            else
            {
                Console.WriteLine("No records found!");
            }
        }
    }
}
