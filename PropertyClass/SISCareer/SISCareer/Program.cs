namespace SISCareer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Career.department = "Analyst Group";
            Career.position = "DataEngineer";
            Career.city = "Duluth";
            Career.state = "GA";
            Console.WriteLine(Career.department);
            Console.WriteLine(Career.position);
            Console.WriteLine(Career.city);
            Console.WriteLine(Career.state);
        }
    }
}