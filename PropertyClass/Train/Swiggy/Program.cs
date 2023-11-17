namespace Swiggy
{
    class Location {
        public string location { get; set; }        
    }
    class search {
        public string searchFood { get; set; }
        public string chooseRestaurant { get; set; }
    }
    class order {
        public string foodname { get; set; }
       
        public double price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}