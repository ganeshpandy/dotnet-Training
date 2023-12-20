namespace Synchronous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void Work() 
        {
            Thread.Sleep(1000);
            Console.WriteLine("Working Method");
        }
        public static void WakeUp() 
        {
            Thread.Sleep(2000);
            Console.WriteLine("WakeUp Method");
        }
        public static void Eat() 
        {
            Thread.Sleep(800);
            Console.WriteLine("Eating Method");
        }
    }
}
