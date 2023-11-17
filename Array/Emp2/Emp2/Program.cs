namespace Emp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Allwyn", "Ganesh", "Gobinathan", "sairam", "saravanaprakash", "Tharmesh", "Chrislyn Jenica", "Kiran", "Manikandan", "Priya", "sneha" };
            int i = 0;
            do
            {
                Console.WriteLine("Welcome to SIS training:" + names[i]);
                i++;
            } while (i < names.Length);

        }
    }
}