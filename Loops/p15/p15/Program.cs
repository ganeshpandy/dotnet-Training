namespace p15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter FoodItem");
            string foodName=Console.ReadLine();
            Console.WriteLine("Enter HotelName");
            string hotelName=Console.ReadLine();
            Console.WriteLine("Enter price");
            double price=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rating");
            int rating = Convert.ToInt32(Console.ReadLine());
            swiggy(foodName, hotelName, price, rating);

        }
        static void swiggy(string foodName, string hotelName, double price, int rating) {
            Console.WriteLine("FoodName:" + foodName);
            Console.WriteLine("HotelName:"+hotelName);
            Console.WriteLine("Price:" + price);
            Console.WriteLine("rating:" + rating);
        }
    }
}