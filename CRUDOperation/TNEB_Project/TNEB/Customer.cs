using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNEB
{
   public class Customer : IBill
    {
        public int EBID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public long Phno { get; set; }
        public int Amount { get; set; }
        public DateOnly date {  get; set; }
        public int Calculate() 
        {
            return Amount;
        }
        public DateOnly Getdate()
        {
            throw new NotImplementedException();
        }
        public void Setdate(DateOnly date)
        {
            Console.WriteLine(date);
        }



        //
        List<Customer> list=new List<Customer>();
        Customer customer = null;

        public List<Customer> CreateCustomer() 
        {
            Customer customer = new Customer();

           
                Console.WriteLine("Enter the CustomerID");
                customer.EBID = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter the CustomerName");
                customer.CustomerName = Console.ReadLine()!;

                Console.WriteLine("Enter the City");
                customer.City = Console.ReadLine()!;

                Console.WriteLine("Enter the Phno");
                customer.Phno = long.Parse(Console.ReadLine()!);

                customer = new Customer()
                {
                    EBID = customer.EBID,
                    CustomerName = customer.CustomerName,
                    City = customer.City,
                    Phno = customer.Phno,
                };
                list.Add(customer);
                Console.WriteLine("Customer details created!");                
                return list;
        }

        public void Update()
        {
            Console.Write("Enter  ID to update: ");
            int UpdateCustomer = int.Parse(Console.ReadLine()!);
            foreach (var data in list)
            {
                if (data.EBID == UpdateCustomer)
                {
                    //OldData = data;
                    Console.WriteLine("Enter New City");
                    data.City = Console.ReadLine()!;
                    Console.WriteLine("Enter New Phno");
                    data.Phno = long.Parse(Console.ReadLine()!);
                    break;
                }
            }                             
        }


    }
}
