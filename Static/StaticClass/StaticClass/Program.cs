using System.ComponentModel.DataAnnotations;

namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Example.Display();            
            //Console.WriteLine("A+B="+Example.Add(2,5));
        }
    }
    public static class Example 
    {
        public static int Id = 1;
        public static string Name = "Alex";
        public static string Place="trichy";
        public static DateOnly Dob = new DateOnly(2015, 12, 25);
        public static void Display() 
        {
            Console.WriteLine("Id       : "+Id);
            Console.WriteLine("Name     : "+Name);
            Console.WriteLine("Place    : "+Place);
            Console.WriteLine("DOB      : "+Dob);
            
        }
        static Example() 
        {                        
            Console.WriteLine("Find the Total =" + Add(33,22,12,45,65));
        }
        public static int Add(int m1,int m2,int m3,int m4,int m5) 
        {
            int total = m1 + m2+m3+m4+m5;
            
            return total;
        }
    }
}
