namespace object2
{
    class student {
        public string name;
        public int id;
        public DateTime dob;
        public string address;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.name = "alex";
            student.dob = DateTime.Now;
            student.address = "london";
            Console.WriteLine("Student Name:"+student.name);
            Console.WriteLine("Student Id:" + student.id);
            Console.WriteLine("student Address:"+student.address);
        }
    }
}