namespace Contact
{
    class ContactUs {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public long phone { get; set; }
        public int size { get; set; }
        public string companyHQ { get; set; }
        public string discuss { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}