
namespace GenarateBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill();
            int calculatedAmount = bill.Calculate();
            Console.WriteLine("Bill Amount\t:"+calculatedAmount);

        }
    }
    class Bill 
    {
        public int OldReading { get; set; }
        public int NewReading { get; set; } 
        public int Amount {  get; set; } 
        public Bill()
        {
            Console.Write("Enter Old Reading: ");
            OldReading = int.Parse(Console.ReadLine()!);

            Console.Write("Enter New Reading: ");
            NewReading = int.Parse(Console.ReadLine()!);

            //Console.Write("Enter Amount: ");
            //Amount = int.Parse(Console.ReadLine()!);
        }
        public int Calculate() 
        {
            int unit = OldReading - NewReading;
            return Amount=unit*10;
        }
    }
}
