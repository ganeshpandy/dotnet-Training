namespace NumToChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");//12
            int n = Convert.ToInt32(Console.ReadLine());                        
            string s= "";//two
            string[]words= { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            while (n !=0) {//12,1
                
                s = words[n%10]+s;//two+" "+""     one+two
                n = n / 10;//1

            }
            Console.WriteLine(s);
        }
    }
}