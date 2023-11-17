namespace Train
{
    class TrainBooking 
    {
        public string from { get; set; }
        public string to { get; set; }
        public DateTime date { get; set; }
        public string classes { get; set; }
        public string general { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}