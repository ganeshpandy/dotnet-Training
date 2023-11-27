using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    class OrderDetails
    {
        List<Order> list = new List<Order>();
        Order order = null,OldOrder=null;

        //Id,Name,OrderType,ModelName,Address,city,amount,phno
        public List<Order> Create()
        {
            order = new Order()
        {
               
                    Id = 101,
                    Name = "Charles",
                    OrderType = "Mobile",
                    ModelName = "Samsung",
                    Address = "Church 5th Street",
                    City = "KKDI",
                    Amount = 12000,
                    PhNo = 123456
                };
                list.Add(order);
                return list;
                        
            
        }
        public void Read()
        {
            if (list.Count > 0)
            {
                foreach (var data in list)
                {
                    Console.WriteLine("Order Id         : " + data.Id);
                    Console.WriteLine("Customer Name    : " + data.Name);
                    Console.WriteLine("OrderType        : " + data.OrderType);
                    Console.WriteLine("ModelName        : " + data.ModelName);
                    Console.WriteLine("Customer Address : " + data.Address);
                    Console.WriteLine("City             : " + data.City);
                    Console.WriteLine("Amount           : " + data.Amount);
                    Console.WriteLine("PhNo             : " + data.PhNo);
                }
            }
            else
            {
                Console.WriteLine("Order not found!");
            }
        }
        public void Update()
        {
            Console.Write("Enter  ID to update: ");
            int UpdateOrder = int.Parse(Console.ReadLine()!);
            foreach (var data in list)
            {
                if (data.Id == UpdateOrder)
                {
                    OldOrder = data;
                    break;
                }
            }
            //Id,Name,OrderType,ModelName,Address,city,amount,phno
            Console.WriteLine("Enter new  Id");
            order.Id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter new  Name");
            order.Name = Console.ReadLine();

            Console.WriteLine("Enter new  Address");
            order.Address = Console.ReadLine();

            Console.WriteLine("Enter new OrderType");
            order.OrderType = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            order.City = Console.ReadLine();

            Console.WriteLine("Enter the PhoneNo");
            order.PhNo = long.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the Amount");
            order.Amount = double.Parse(Console.ReadLine()!);            
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
