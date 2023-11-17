namespace num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 123;
            Console.WriteLine("\nChange Number " + n + " Into Words!!");
            Console.WriteLine("---------------------------------------------------");
            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string s = " ";
            for (; n != 0; n /= 10)
                s = words[n % 10] + " " + s;

            Console.WriteLine(s);
        }
    }
}