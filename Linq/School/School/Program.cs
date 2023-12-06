namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            List<Student> stud = student.LoadStudent();
            student.Display();


        }
    }
}
