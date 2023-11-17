namespace Constructor3
{
    class Order {
        string CompanyName;
        int orderId;
        string orderType;
        string mobile;
        string mobileModel;
        double price;
        public Order(int orderId,string orderType, string mobile, string mobileModel, double price) {
            this.orderId = orderId;
            this.orderType = orderType;
            this.mobile = mobile;
            this.mobileModel = mobileModel;
            this.price = price;
            Console.WriteLine(CompanyName);
            }
        public void read() {            
            Console.WriteLine(orderId);
            Console.WriteLine(orderType);
            Console.WriteLine(mobile);
            Console.WriteLine(mobileModel);
            Console.WriteLine(price);
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the orderId");
            int orderId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the orderType");
            string orderType=Console.ReadLine();
            Console.WriteLine("Enter the mobileName");
            string mobile=Console.ReadLine();
            Console.WriteLine("Enter the mobileModel");
            string mobileModel=Console.ReadLine();
            Console.WriteLine("Enter the price");
            double price=Convert.ToDouble(Console.ReadLine());            
            Order orderObj=new Order(orderId, orderType, mobile, mobileModel, price);
            orderObj.read();
        }
    }
}