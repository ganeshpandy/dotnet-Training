namespace Redbus
{
    class Busticket {
        public string from { get; set; }
        public string to { get; set; }
        public DateTime date { get; set; }       
    }
    class filters {
        public DateTime departureTime { get; set; }
        public string busTypes { get; set; }
        public DateTime arrivalTime { get; set; }        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}