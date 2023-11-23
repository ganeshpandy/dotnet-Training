using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IMethods
    {
        void Writting();
        void Reading();
        void Eating();
        double GetMark();
    }
    public abstract class BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void DisplayDetail();
        public virtual void SetMark(double Mark)
        {
        }
    }
    public class Student : BaseClass, IMethods
    {
        public double TotalMark { get; set; }

        public Student(int Id, string Name, double TotalMark)
        {
            this.Id = Id;
            this.Name = Name;
            this.TotalMark = TotalMark;
        }
        public override void DisplayDetail()
        {

            Console.WriteLine("ID      -  " + Id);
            Console.WriteLine("NAME    -  " + Name);
        }
        public void Add(int Id)
        {
            Console.WriteLine(Id);
        }
        public void Add(int Id, string Name)
        {

        }
        public void Writting()
        {
            Console.WriteLine("I'm Writting !");
        }

        public void Reading()
        {
            Console.WriteLine("I'm Reading !");
        }

        public void Eating()
        {
            Console.WriteLine("I'm Eating !");
        }

        public double GetMark()
        {
            return TotalMark;
        }
        public override void SetMark(double Mark)
        {
            Console.WriteLine("Total Mark   -   " + Mark);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student(1, "Tharmeshwaran", 450);
            student.DisplayDetail();
            student.Writting();
            student.Reading();
            student.Eating();
            student.SetMark(student.GetMark());
        }
    }
}
