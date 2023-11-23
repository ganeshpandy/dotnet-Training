using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
     class OrderDetails
    {
        public List<Order> AddOrder()
        {
            List<Order> list = new List<Order>()
        {
        new Order() 
        {Id=101,Name="Charles",OrderType="Mobile",MobileName="Samsung",Address="Chennai",City="KKDI",Amount=12000,PhNo=123456}
        };
            return list;
        }
        public void DisplayOrder(List<Order> orders) 
        {
            foreach (var data in orders) 
            {
                Console.WriteLine("Order Id:" + data.Id);
                Console.WriteLine("Customer Name:" + data.Name);
                Console.WriteLine("OrderType:" + data.OrderType);
                Console.WriteLine("MobileName:" + data.MobileName);
                Console.WriteLine("Address:" + data.Address);
                Console.WriteLine("Amount:" + data.Amount);
                Console.WriteLine("City:" + data.City);
                Console.WriteLine("PhNo:" + data.PhNo);
            }
        }
        
    }
}
