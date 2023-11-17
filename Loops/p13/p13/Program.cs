namespace p13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Movie Ticket Details");
            Console.WriteLine("Enter Theatre Name");
            string theatre=Console.ReadLine();
            Console.WriteLine("Enter Date");
            string date=Console.ReadLine();
            Console.WriteLine("Enter time");
            string time=Console.ReadLine();
            Console.WriteLine("Enter seatno");
            int seatNo=Convert.ToInt32(Console.ReadLine());
            movie(theatre, date, time, seatNo);

        }
        static void movie(string theatre,string date,string time,int seatNo) {
            Console.WriteLine("Theatre Name:" + theatre);
            Console.WriteLine("Date:" + date);
            Console.WriteLine("time:" + time);
            Console.WriteLine("seatNo:" + seatNo);
        }
    }
}