/*namespace StudentMarks
{
    class Student
    {
        public int Id { get; set; }
        public string StudName { get; set; }
        public string? Standard { get; set; }
        public string? Section { get; set; }
        public Student(int Id, string StudName, string Standard, string Section)
        {
            this.Id = Id;
            this.StudName = StudName;
            this.Standard = Standard;
            this.Section = Section;
        }
    }
    class Subject : Student
    {
        public int Tamil;
        public int English;
        public int Maths;
        public int Chemistry;
        public int Physics;
        public Subject(int Tamil, int English, int Maths, int Physics, int Chemistry)
        {
            this.Tamil = Tamil;
            this.English = English;
            this.Maths = Maths;
            this.Physics = Physics;
            this.Chemistry = Chemistry;
        }
    }
    class Mark : Subject
    {
        public void marks()
        {
            Tamil = Convert.ToInt32(Console.ReadLine());
            English = Convert.ToInt32(Console.ReadLine());
            Maths = Convert.ToInt32(Console.ReadLine());
            Physics = Convert.ToInt32(Console.ReadLine());
            Chemistry = Convert.ToInt32(Console.ReadLine());
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student(101, "alex", "10th", "A");
        }
    }
}
*/