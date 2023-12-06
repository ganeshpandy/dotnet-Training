namespace Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeRegistration college= new CollegeRegistration();
            List<CollegeRegistration> Reg = college.LoadDetails();

            Console.WriteLine("Enter the Id to search:");
            string FindName = Console.ReadLine()!;

            var Selected = from data in Reg
                           where data.Name == FindName
                           select data;
            foreach (var item in Selected)
            {
                Console.WriteLine($"Name:{item.Name}\nCollegeName: {item.CollegeName}\n" +
                    $"Course: {item.Course}\nPhno:{item.Phno}");
            }
        }
    }
}
