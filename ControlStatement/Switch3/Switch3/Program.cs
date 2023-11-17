namespace Switch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //game moments
            string moments =Console.ReadLine();
            switch (moments)
            {
                case "space":
                    Console.WriteLine("for jump");
                    break;
                case "left":
                    Console.WriteLine("for move left");
                    break;
                case "right":
                    Console.WriteLine("for move right");
                    break;
                case "up":
                    Console.WriteLine("for move forward");
                    break;
                case "down":
                    Console.WriteLine("for move downward");
                    break;
                default:
                    Console.WriteLine("invalid key option");
                    break;

            }
        }
}