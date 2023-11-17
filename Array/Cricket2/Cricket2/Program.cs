namespace Cricket2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ganeshpandy", "Rohit", "Kohil", "KLrahul", "Shreyas", "SuryaKumar", "jadeja", "Shami", "Bumrah", "Kuldeep", "Siraj" };
            int i = 0;
            do
            {
                Console.WriteLine("Indian Squad Members:" + names[i]);
                i++;
            } while (i < names.Length);
        }
    }
    }
