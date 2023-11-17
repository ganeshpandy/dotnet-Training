namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age:");
            int age = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Your Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Your Email:");
            string email = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Name:" +name+ "\n" + "Age" +age+ "\n" +"Address:"+address+"\n"+"Email:"+email);

        }
    }
}