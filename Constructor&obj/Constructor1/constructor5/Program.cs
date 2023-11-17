namespace constructor5
{
    class Student
    {
        string CollegeName;
        public Student(string CollegeName,int id, string empName, string address)
        {
            Console.WriteLine("College Name:" + CollegeName);
            Console.WriteLine("Student ID:" + id);
            Console.WriteLine("Student Name:" + empName);
            Console.WriteLine("Address:" + address);
        }
        /*public Student()
        {
            
        }*/
        internal class Program
        {
            static void Main(string[] args)
            {
                Student stud1 = new Student("Alagappa University",101, "alex", "chennai");                
            }
        }
    }
}