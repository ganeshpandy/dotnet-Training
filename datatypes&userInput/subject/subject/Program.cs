namespace subject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(tamil.name);
            Console.WriteLine(tamil.mark);
            Console.WriteLine(tamil.rank);
            tamil.remark();
            tamil.status();
            Console.WriteLine("------------------");
            Console.WriteLine(english.name);
            Console.WriteLine(english.mark);
            Console.WriteLine(english.rank);
            english.status();
            english.remark();
            Console.WriteLine("------------------");
            Console.WriteLine(hindi.name);
            Console.WriteLine(hindi.mark);
            Console.WriteLine(hindi.rank);
            hindi.status();
            hindi.remark();

        }
    }
}