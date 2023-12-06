using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiggy
{
     class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HotelName { get; set; }
        public double Amount { get; set; }
        public void OrderList() 
        {
            Console.WriteLine("FriedRice");
            Console.WriteLine("Biryani");
            Console.WriteLine("GrillChicken");
        }
        List<Order> list = new List<Order>();
        Order order = null;
        public List<Order> LoadDetails()
        {

            Order order = new Order();

            Console.WriteLine("Enter Order Id");
            order.Id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter CustomerName");
            order.Name = Console.ReadLine()!;

            Console.WriteLine("Enter HotelName");
            order.HotelName = Console.ReadLine()!;

            Console.WriteLine("Enter Amount");
            order.Amount = double.Parse(Console.ReadLine()!);

            new Order()
            {
                Id = order.Id,
                Name = order.Name,
                HotelName = order.HotelName,
                Amount = order.Amount,
            };
            list.Add(order);
            return list;
        }
    }
}
