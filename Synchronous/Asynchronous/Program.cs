namespace Asynchronous
{
    internal class Program
    {
        
        static async Task Main(string[] args)
        {
            await WakeUp();
            await Eat();
            await Work();           
            
        }
        public static async Task Work()
        {            
            await Task.Run(() => 
            {
                Thread.Sleep(1000);
                Console.WriteLine("Working Method");
            });            
        }
        public static async Task WakeUp()
        {
            await Task.Run(() => 
            {
                Thread.Sleep(2000);
                Console.WriteLine("WakeUp Method");
            });
            
        }
        public static async Task Eat()
        {
            await Task.Run(() => 
            {
                Thread.Sleep(800);
                Console.WriteLine("Eating Method");
            });
            
        }
    }
    
}
