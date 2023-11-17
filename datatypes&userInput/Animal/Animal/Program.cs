namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(dog.animalName);
            Console.WriteLine(dog.gender);
            Console.WriteLine(dog.color);
            Console.WriteLine(dog.breed);
            dog.play();

            Console.WriteLine("------------------------------");
            Console.WriteLine(cat.animalName);
            Console.WriteLine(cat.gender);
            Console.WriteLine(cat.color);
            cat.foodItem();

            Console.WriteLine("------------------------------");
            Console.WriteLine(cow.animalName);
            Console.WriteLine(cow.weight);
            cow.gives();

            Console.WriteLine("------------------------------");
            Console.WriteLine(tiger.animalName);
            Console.WriteLine(tiger.speed);
            tiger.hunt();
        }
    }
 
}