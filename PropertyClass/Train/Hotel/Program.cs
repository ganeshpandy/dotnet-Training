namespace Hotel
{
    class HotelBooking
    {
        public string name { get; set; }
        public string location { get; set; }
    }
    class room
    {
        public int roomNo { get; set; }
        public double price { get; set; }
        public TimeOnly time { get; set; }
        public bool isbool { get; set; }
    }
    class customer
    {
        public string name { get; set; }
        public string email { get; set; }
        public long phno { get; set; }
        public long aadhar { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
