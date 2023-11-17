namespace StudentMarks
{
    class Student 
    {
        public int Id { get; set; }
        public string StudName {  get; set; }
        public string? Standard { get; set; }
        public string? Section { get; set; }
        public void studDetails(int Id, string StudName, string Standard, string Section)
        {
            this.Id = Id;
            this.StudName = StudName;
            this.Standard = Standard;
            this.Section = Section;
        }
    }
    class Subject:Student
    {        
        public int Tamil;
        public int English;
        public int Maths;
        public int Chemistry;                
        public int Physics;
        public void subjectDetails(int Tamil, int English, int Maths, int Physics, int Chemistry)
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
        public void marks() {
            Console.WriteLine("Enter the 5 marks");
            Tamil=Convert.ToInt32(Console.ReadLine());
            English = Convert.ToInt32(Console.ReadLine());
            Maths = Convert.ToInt32(Console.ReadLine());
            Physics = Convert.ToInt32(Console.ReadLine());
            Chemistry = Convert.ToInt32(Console.ReadLine());
            subjectDetails(Tamil, English, Maths, Physics, Chemistry);
        }
        public void displayMark() {
            Console.WriteLine("");
            Console.WriteLine(Tamil);
            Console.WriteLine(English);
            Console.WriteLine(Maths);
            Console.WriteLine(Physics);
            Console.WriteLine(Chemistry);
        }
        
    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Mark mark = new Mark();
            mark.studDetails(101, "alex", "10th", "A");
            Console.WriteLine(mark.Id + "\n"+mark.StudName+"\n" + mark.Standard+ "\n" + mark.Section);
            mark.marks();
            mark.displayMark();
        }
    }
}
