using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    class GenrateBill<T> : CustomerDetails<T>
    {
        //list.Display(list.GetName());
        public T? OldReading { get; set; }
        public T? NewReading { get; set; }
        public T? Amount { get; set; }

        /*public void GetAmount(T value) 
        {            
            Console.WriteLine(value);
        }
        public T SetAmount(T Amount) 
        {
            Amount = OldReading - NewReading;
        }*/
        
    //CustomerID,CustomerName,Address,Phno
    List<CustomerDetails<T>> list = new List<CustomerDetails<T>>();

        List<GenrateBill<T>> billList = new List<GenrateBill<T>>();

        GenrateBill<T> bill = null, OldCus = null;
        public List<CustomerDetails<T>> CreateCustomer()
        {
            CustomerDetails<T> customer = new CustomerDetails<T>();

            Console.Write("Enter customer ID : ");
            CustomerDetails<T> customer1 = new CustomerDetails<T>();
            customer1.CustomerID = (T)(object)int.Parse(Console.ReadLine()!);

            Console.Write("Enter Customer Name : ");
            CustomerDetails<T> CustomerName = new CustomerDetails<T>();
            CustomerName.CustomerName = (T)(object)Console.ReadLine()!;

            Console.Write("Enter Customer Address : ");
            CustomerDetails<T> Address = new CustomerDetails<T>();
            Address.Address = (T)(object)Console.ReadLine()!;

            Console.Write("Enter Customer Phno : ");
            CustomerDetails<T> Phno = new CustomerDetails<T>();
            Phno.Phno = (T)(object)long.Parse(Console.ReadLine()!);

            customer = new CustomerDetails<T>()
            {
                CustomerID = customer.CustomerID,
                CustomerName = customer.CustomerName,
                Address = customer.Address,
                Phno = customer.Phno,
            };
            list.Add(customer);
            Console.WriteLine("customer details created!");
            return list;
        }
        //OldReading,NewReading,Amount
        public List<GenrateBill<T>> CreateBill()
        {            
            GenrateBill<T> bill = new GenrateBill<T>();

            Console.Write("Enter OldReading : ");
            bill.OldReading = (T)(object)Console.ReadLine()!;

            Console.Write("Enter NewReading : ");
            bill.NewReading = (T)(object)Console.ReadLine()!;

            Console.Write("Enter Amount : ");
            bill.Amount = (T)(object)long.Parse(Console.ReadLine()!);

            billList.Add(bill);
            return billList;
        }
        //CustomerID,CustomerName,Address,Phno
        //OldReading,NewReading,Amount
        public void Read()
        {
            if (list != null && billList.Count > 0)
            {
                foreach (var customers in list)
                {
                    Console.WriteLine("Customer ID      :"+ customers.CustomerID);
                    Console.WriteLine("CustomerName ID  :"+ customers.CustomerName);
                    Console.WriteLine("Customer Address :"+ customers.Address);
                    Console.WriteLine("Customer Phno    :"+ customers.Phno);
                }
                foreach (var bills in billList)
                {                   
                    Console.WriteLine("OldReading      :" + bills.OldReading);
                    Console.WriteLine("NewReading  :" + bills.CustomerName);
                    Console.WriteLine("Amount :" + bills.Amount);                    
                }
            }            
        }
        public void Update()
        {
            Console.Write("Enter  ID to update: ");
            int UpdateCus = int.Parse(Console.ReadLine()!);            

            foreach (var data in billList)
            {
                if (data.CustomerID == UpdateCus)
                {
                    OldCus = data;
                    break;
                }
            }
            //OldReading,NewReading,Amount
            Console.Write("Enter OldReading: ");
                billList.OldReading = int.Parse(Console.ReadLine());

                Console.Write("Enter New NewReading: ");
                billList.NewReading = Console.ReadLine();

                Console.Write("Enter Amount : ");
                billList.Amount = Console.ReadLine();
               
                Console.WriteLine("Details updated!");            
            
        }
        public void Delete() 
        {
            if (true)
            {
                list.Clear();
                billList.Clear();
                Console.WriteLine("All records deleted!");
            }
            else
            {
                Console.WriteLine("No records found!");
            }
        }
    }
}
