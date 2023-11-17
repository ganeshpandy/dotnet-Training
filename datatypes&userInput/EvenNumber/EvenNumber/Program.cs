namespace EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=Convert.ToInt32(Console.ReadLine());
            even(n);
            Console.WriteLine();
        }
        static void even(int n) { 
        if(n%2==0)
            {
                Console.WriteLine("this is even number");
            }
        }
    }
}