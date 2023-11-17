namespace p5
{
     class Program
    {
        static void Main(string[] args)
        {
            Motorcycle m = new Motorcycle();
            m.StartEngine();

            Car car = new Car();
            car.StartEngine();

            Console.ReadKey();
        }
    }
    public class Vehicle
    {
        public virtual void StartEngine() { }
    }
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started!");
        }
    }
    public class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started!");
        }
    }
}