namespace Hierarchical
{
    class Car {
        public string Name = "Ford";
    }
    class MusicPlayer : Car {
        public void musicPlayer() {
            Console.WriteLine("Music Player is on");
        }
    }
    class Engine : Car {
        public void EngineWork() {
            Console.WriteLine("Car Started Moving");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            Console.WriteLine(engine.Name);
            engine.EngineWork();                                    
        }
    }
}