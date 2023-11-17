namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size=Convert.ToInt32(Console.ReadLine());
            string[] a = new string[size];
            
            Console.WriteLine("Enter the name");
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = Console.ReadLine();
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            
        }
    }
}