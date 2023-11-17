using System.Net;
using System.Xml.Linq;

namespace Order
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Id");
             int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Item:");
             string? Item = Console.ReadLine();
            Console.WriteLine("Enter the Category:");
            string? Category = Console.ReadLine();
            Console.WriteLine("Enter the OrderQty:");
            string? OrderQty = Console.ReadLine();
            Console.WriteLine("Enter the Price:");
            Double Price = Convert.ToDouble(Console.ReadLine());

            Order order = new Order(Id, Item, Category, OrderQty, Price);

            string FilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Order.txt";
            //FileStream f = System.IO.File.Create(FilePath);
            string orderData = "Order Id:" + order.Id + "\n Order Item:" + order.Item +
                "\n Order Category:" + order.Category + "\n Order OrderQty:" + order.OrderQty +
                "\n Price:" + order.Price;
            System.IO.File.WriteAllText(FilePath, orderData);
            Console.WriteLine("Data Created:\n" + orderData);
        }
    }
    class Order 
    {
        public int Id {  get; set; }
        public string Item { get; set; }
        public string Category { get; set; }
        public string OrderQty { get; set; }
        public double Price { get; set; }

        /*public int Id=0;
        public string Item="";
        public string Category = "";
        public string OrderQty = "";
        public double Price = 0;*/
        public Order(int Id,string Item,string Category,string OrderQty,double Price) { 
            this.Id=Id;
            this.Item=Item;
            this.Category=Category;
            this.OrderQty=OrderQty;
            this.Price=Price;        
        }
       
    }
}