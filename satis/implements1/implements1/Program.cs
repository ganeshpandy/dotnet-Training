namespace Interfaces
{
    public interface Address
    {
 
        public int Doorno { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public int pincode { get; set; }
 
        public void display(int Doorno, string street, string city, int pincode)
        {
            Doorno = 101;
            street = "Church 5th Street";
            city = "Karaikudi";
            pincode = 630001;
        }
    }
    class student:Address
    {
        public int Doorno { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public int pincode { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public student(int id,string Name, string Course)
        {
            this.id = id;
            this.Name = Name;
            this.Course = Course;
        }
    }
    internal class Program
    {
 
        static void Main(string[] args)
        {
            student myObj = new student(101,"alex","Dotnet");
 
 
        }
    }
}