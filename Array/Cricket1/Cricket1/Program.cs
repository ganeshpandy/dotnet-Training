namespace Cricket1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ganeshpandy", "Rohit", "Kohil", "KLrahul", "Shreyas", "SuryaKumar", "jadeja", "Shami", "Bumrah", "Kuldeep", "Siraj" };
            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine("Indian Squad Members:" + names[i]);
                i++;
            }
        }
    }
}