namespace Amazon
{
    internal class Program
    {
        static void Main(string[] args)
        {
           OrderDetails orderDetails = new OrderDetails();
            List<Order> ordersobj = orderDetails.AddOrder();
            orderDetails.DisplayOrder(ordersobj);
            
        }
    }
}
