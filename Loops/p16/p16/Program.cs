namespace p16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Passenger Name");
            string name=Console.ReadLine();
            Console.WriteLine("From Location");
            string locationFrom=Console.ReadLine();
            Console.WriteLine("To Location");
            string locationTo=Console.ReadLine();
            Console.WriteLine("Date");
            string  date=Console.ReadLine();
            Console.WriteLine("price");
            float price=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("seatNo");
            int seatNo=Convert.ToInt32(Console.ReadLine());
            train(name, locationFrom, locationTo, date, price, seatNo);
        }
        static void train(string name, string locationFrom, string locationTo, string date, float price, int seatNo) {
            Console.WriteLine("Passenger Name:"+name);
            Console.WriteLine("From:" + locationFrom);
            Console.WriteLine("To:" + locationTo);
            Console.WriteLine("Date" + date);
            Console.WriteLine("Price:" + seatNo);
        }
    }
}