namespace Switch5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A character");
            char ch=Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'a':
                    Console.WriteLine("A is vowel letter");
                    break;
                case 'e':
                    Console.WriteLine("E is vowel letter");
                    break;
                case 'i':
                    Console.WriteLine("I is vowel letter");
                    break;
                case 'o':
                    Console.WriteLine("O is vowel letter");
                    break;
                case 'u':
                    Console.WriteLine("U is vowel letter");
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
        }
    }
}