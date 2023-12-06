using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNEB
{
     class Bill:Customer
    {
        public int OldReading {  get; set; }
        public int NewReading { get; set; }
        public DateOnly date { get; set; }
        public int Calculate(List<Bill>billList)
        {
            int unit = 0;
            unit = NewReading - OldReading;
           //OldReading = NewReading;
            return unit * 8;
        }        
        public DateOnly Getdate()
        {
            return date;
        }
        List<Bill> billList = new List<Bill>();
        Bill bill = null;
        public List<Bill> Getbill()
        {
            billList=new List<Bill>();
            Console.Write("Enter Old Reading: ");
            OldReading = int.Parse(Console.ReadLine()!);

            Console.Write("Enter New Reading: ");
            NewReading = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Due Date: ");
            date = DateOnly.Parse(Console.ReadLine()!);

             bill = new Bill()
            {
                 OldReading = bill.OldReading,
                 NewReading = bill.NewReading,
                 date = bill.date,                
            };
            billList.Add(bill);
            Console.WriteLine("Customer details created!");
            return billList;
        }
        
        public void Read()
        {
            if (billList.Count > 0)
            {
                foreach (var data in billList)
                {
                    Console.WriteLine("customer Id    : " + data.EBID);
                    Console.WriteLine("customer Name  : " + data.CustomerName);
                    Console.WriteLine("customer City  : " + data.City);
                    Console.WriteLine("customer Phno  : " + data.Phno);
                    Console.WriteLine("OldReading  : " + data.OldReading);
                    Console.WriteLine("NewReading  : " + data.NewReading);
                    Console.WriteLine("Amount  : " + data.Amount);

                }
            }
            else
            {
                Console.WriteLine("Customer not found!");
            }
        }
        public void UpdateBill() 
        {
            Console.Write("Enter  ID to update: ");
            int UpdateBill = int.Parse(Console.ReadLine()!);
            foreach (var data in billList) 
            {
                if (data.EBID == UpdateBill)
                {
                    //OldBill = data;
                    Console.WriteLine("Enter NewReading");
                    NewReading=int.Parse(Console.ReadLine()!);
                    break;
                }
            }            
        }

    }
}
