namespace MultiLevel
{
    class University {
      public string UniversityName="ALAGAPPA";
    }
    class College: University
    {
        public string CollegeName="ANANDA";
    }
    class Student : College 
    {
        public String StudName;
        public Student(String StudName) { 
        this.StudName = StudName;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student("alex");
            Console.WriteLine(obj.CollegeName);
            Console.WriteLine(obj.UniversityName);            
            Console.WriteLine(obj.StudName);
        }
    }
}