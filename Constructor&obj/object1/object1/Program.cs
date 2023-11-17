namespace object1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car carobj = new car();
            carobj.name = "Ford";
            carobj.color = "red";
            carobj.price = 500000;
            
            Console.WriteLine("Car Name:"+carobj.name);
            Console.WriteLine("Car Price:"+carobj.price);
            Console.WriteLine("Car Color:"+carobj.color);
        }
    }
    class car {
        public string name;
        public string color;
        public double price;


    }
}