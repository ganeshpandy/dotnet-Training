namespace NestedElse3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Are you a student (yes/no): ");
            string isStudent = Console.ReadLine().ToLower();

            if (age < 12)
            {
                Console.WriteLine("Child ticket: $5");
            }
            else if (age >= 12 && age < 18 || isStudent == "yes")
            {
                Console.WriteLine("Student ticket: $10");
            }
            else
            {
                Console.WriteLine("Adult ticket: $15");
            }
        }
    }
    }
}