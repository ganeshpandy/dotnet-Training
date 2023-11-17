namespace training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(java.courseName);
            Console.WriteLine(java.fees);
            Console.WriteLine(java.duration);
            java.task();
            java.teach();
            Console.WriteLine("--------------------");
            Console.WriteLine(python.courseName);
            Console.WriteLine(python.fees);
            Console.WriteLine(python.duration);
            python.task();
            python.teach();
            Console.WriteLine("--------------------");
            Console.WriteLine(csharp.courseName);
            Console.WriteLine(csharp.fees);
            Console.WriteLine(csharp.duration);
            csharp.task();
            csharp.teach();
        }
    }
}