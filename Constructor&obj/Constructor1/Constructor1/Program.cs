namespace Constructor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mobile mobileObj=new mobile("alex");  
            mobileObj.read();

        }
    }
    class mobile {
        string mobileName;
        public mobile(string Name){
            mobileName = "samsung";
        Console.WriteLine("I am Example with Parameter");
        }
        public void read() {
            Console.WriteLine("I am from Read Method and displaying mobile name");
            Console.WriteLine(mobileName);
        }
        public void write()
        {
            Console.WriteLine("I am from write Method and Example Class");
            Console.WriteLine(mobileName);
        }
    }
}