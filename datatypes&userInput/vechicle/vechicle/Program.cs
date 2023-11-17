namespace vechicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(car.name);
            Console.WriteLine(car.model);
            Console.WriteLine(car.color);
            car.start();
            car.drive();
            Console.WriteLine("---------------");
            Console.WriteLine(bike.name);
            Console.WriteLine(bike.model);
            Console.WriteLine(bike.color);
            bike.accelator();
            bike.brake();
            Console.WriteLine("---------------");
            Console.WriteLine(scooty.name);
            Console.WriteLine(scooty.model);
            Console.WriteLine(scooty.price);
            scooty.engine();
            scooty.seat();
        }
    }
}