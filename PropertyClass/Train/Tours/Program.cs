namespace Tours
{
    class flights {
        public string from { get; set; }
        public string to { get; set; }
        public DateTime date { get; set; }
        public string  classes { get; set; }
    }
    class hotels {
        public string location { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public string classes { get; set; }
    }
    class customerDetails {
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