namespace Test1
{
     class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student("101","Ben","Ten",15,1234567890);
            student.SetStudentID(student.GetStudentID());
            student.Display();            
            student.SubmitAssignment();
            student.EnrollCourse();
        }
    }
}
