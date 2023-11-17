namespace Student
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Name:");
            string? Name=Console.ReadLine();
            Console.WriteLine("Enter Tamil Mark");
            int Tamil=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter English Mark");
            int English = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maths Mark");
            int Maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Science Mark");
            int Science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Social Mark");
            int Social = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(Name,Tamil,English,Maths,Science,Social);
            
            Console.WriteLine("Student Name:"+Name);
            Console.WriteLine("Tamil Mark:"+Tamil);
            Console.WriteLine("English Mark:"+English);
            Console.WriteLine("Maths Mark:"+Maths);
            Console.WriteLine("Science Mark:"+Science);
            Console.WriteLine("Social Mark:"+Social);
            Console.WriteLine("Result");
            student.Average();

        }
    }
}