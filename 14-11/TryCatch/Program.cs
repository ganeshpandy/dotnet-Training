namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int div = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                Console.WriteLine("finally executed");
            }
        }
    }
}