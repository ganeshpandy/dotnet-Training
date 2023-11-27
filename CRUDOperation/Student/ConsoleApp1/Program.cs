namespace ConsoleApp1
{
    public interface IMethods
    {
        double GetMark();
    }
    public abstract class BaseClass
    {
         public virtual void SetMark(double Mark)
        {
        }
    }
    public class Student : BaseClass, IMethods
    {
        public double TotalMark { get; set; }

        public Student(double TotalMark)
        {
            
            this.TotalMark = TotalMark;
        }
       public double GetMark()
        {
            return TotalMark;
        }
        public override void SetMark(double Mark)
        {
            Console.WriteLine("Total Mark   -   " + TotalMark);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student(450);
             student.SetMark(student.GetMark());
        }
    }
}
