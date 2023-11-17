namespace p1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the CarName:");
            string? CarName=Console.ReadLine();
            Console.WriteLine("Enter the CarModel");
            string? CarModel=Console.ReadLine();
            Console.WriteLine("Car Color:");
            string? Color=Console.ReadLine();

           Car car = new Car(CarName,CarModel,Color);
            car.Start(CarName,CarModel,Color);

        }
    }   
}