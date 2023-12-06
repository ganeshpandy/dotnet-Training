using Medical;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Customer
{
    public class CustomerDetails : SaveCustomer
    {
        
        List<SaveCustomer>list = new List<SaveCustomer>();
        public List<SaveCustomer> Create()
        {
            SaveCustomer customer = new SaveCustomer();

            Console.Write("Enter Customer ID : ");
            customer.CustomerId = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name : ");
            customer.CustomerName = Console.ReadLine();
           
            Console.Write("Enter Customer Place : ");
            customer.Place = Console.ReadLine();

            Console.Write("Enter Customer Phone Number : ");
            customer.PhoneNumber = long.Parse(Console.ReadLine()!);

            Console.Write("Enter Customer Date Of Purchase : ");
            customer.Date = DateOnly.Parse(Console.ReadLine()!);

            SaveCustomer getCustomer = new SaveCustomer
            {
                CustomerId = customer.CustomerId,
                CustomerName = customer.CustomerName,                
                Place = customer.Place,
                PhoneNumber = customer.PhoneNumber,
                Date = customer.Date,                
                Amount= customer.Amount,                
            };
            list.Add(getCustomer);
            Console.WriteLine("Customer details created!");
            return list;
        }
        public void Read()
        {
            if(list != null && list.Count > 0)
            {
                foreach (var data in list)
                {
                    Console.WriteLine("Customer ID      : " + data.CustomerId);
                    Console.WriteLine("Customer Name    : " + data.CustomerName);                    
                    Console.WriteLine("Customer Place   : " + data.Place);
                    Console.WriteLine("Customer Phoneno : " + data.PhoneNumber);
                    Console.WriteLine("Amount           : " + data.Amount);
                    Console.WriteLine("DateOfPurchase   : " + data.Date);                                 
                }
            }
            else
            {
                Console.WriteLine("No details found!, please enter details");
            }
        }
        public void Update()
        {
            Console.Write("Enter  ID to update: ");
            int UpdateCus = int.Parse(Console.ReadLine()!);

            SaveCustomer existingCustomer = null!;

            foreach (var data in list)
            {
                if (data.CustomerId == UpdateCus)
                {
                    existingCustomer = data;
                    break;
                }
            }
            if (existingCustomer != null)
            {
                Console.Write("Enter New Customer Name: ");
                existingCustomer.CustomerName = Console.ReadLine();

                Console.Write("Enter New Customer Place : ");
                existingCustomer.Place = Console.ReadLine();

                Console.Write("Enter New Customer Phone Number : ");
                existingCustomer.PhoneNumber = long.Parse(Console.ReadLine()!);

                Console.Write("Enter New Customer Date Of Purchase : ");
                existingCustomer.Date = DateOnly.Parse(Console.ReadLine()!);
                
                Console.Write("Enter New Amount : ");
                existingCustomer.Amount = double.Parse(Console.ReadLine()!);

                Console.WriteLine("Customer details updated!");
            }
            else
            {
                Console.WriteLine("Customer not found!");
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
    }
}
