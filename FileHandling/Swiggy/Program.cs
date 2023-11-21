namespace Swiggy
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter HotelName");
            string? HotelName = Console.ReadLine();

            Console.WriteLine("Enter FoodName");
            string? FoodName = Console.ReadLine();

            Console.WriteLine("Enter OrderQty");
            string? OrderQty = Console.ReadLine();

            Console.WriteLine("Price");
            double Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address");
            string? Address = Console.ReadLine();

            //object
            Order order = new Order(HotelName, FoodName, OrderQty,Price, Address);
            string FilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Swiggy\\Files\\CreateRecord.txt";

            //FileStream f = System.IO.File.Create(FilePath);
            string RecordData = "HotelName:" + HotelName + "\n FoodName:" + FoodName +
               "\n OrderQty:" + OrderQty + "\n Price:" + Price+ "\n Address"+ Address;

            System.IO.File.WriteAllText(FilePath, RecordData);
            //Console.WriteLine("Data Created:\n" + RecordData);
            order.Details();

        }
    }
}