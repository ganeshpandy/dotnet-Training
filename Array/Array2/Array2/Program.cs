namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 7, 3, 9, 4, 1, 8, 5 };
            Array.Sort(a);
            foreach (int i in a) { 
            Console.Write(i+",");
            }
        }
    }
}