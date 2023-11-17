namespace DecimalValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n=Console.ReadLine();
            decimal value;
            if(decimal.TryParse(n, out decimal d)) 
            {
                Console.WriteLine("isvalid");
            }
            else
            {
                Console.WriteLine("not valid");
            }

        }
    }
}