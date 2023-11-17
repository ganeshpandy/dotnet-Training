namespace MethodOverLoading
{
    public class Calc
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine(Calc.add(12, 23));
            Console.WriteLine(Calc.add(12, 23, 25));
        }
    }
}