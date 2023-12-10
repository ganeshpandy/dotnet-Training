namespace Calc
{
    delegate void Calulator(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calulator cal=new Calulator(Add);//delegate method

            cal(3,5);//calling delegate method
        }
        public static void Add(int a,int b) 
        {
        Console.WriteLine(a+b);
        }
        public static void Sub(int a,int b) 
        {
            Console.WriteLine(a-b);
        }
    }

}
