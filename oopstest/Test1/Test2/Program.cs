namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id = Console.ReadLine()!;
            //"alex",12000,DateTime.Now,"Male",1234567890
            Worker worker = new Worker(101,"alex", 12000, DateTime.Now, "Male", 1234567890);
            worker.DisplayDetails();
            worker.Enrollment();
            worker.GetworkerID();
            Console.WriteLine();
            Console.WriteLine();
            Worker2 worker2=new Worker2(102,"ban", 12000, DateTime.Now, "Male", 1234567890,"Tester");
            worker2.DisplayDetails();
            worker2.Enrollment();
            worker2.GetworkerID();


        }
    }
}
