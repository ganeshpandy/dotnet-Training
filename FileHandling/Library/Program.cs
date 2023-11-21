namespace Library
{
     class Program
    {
        /*public Record(int Id, string CustomerName, string BookName, string Date)*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer Id");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter CustomerName");
            string? CustomerName = Console.ReadLine();            

            Console.WriteLine("Enter BookName");
            string? BookName = Console.ReadLine();

            Console.WriteLine("Date");
            string? Date=Console.ReadLine();

            //object
            Record record = new Record(Id,CustomerName,BookName,Date);
            string FilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\CreateRecord.txt";

            //FileStream f = System.IO.File.Create(FilePath);
            string RecordData = "Id:" + Id + "\n CustomerName:" + CustomerName +
               "\n BookName:" + BookName + "\n Date:" + Date;

            System.IO.File.WriteAllText(FilePath, RecordData);
            //Console.WriteLine("Data Created:\n" + RecordData);
            record.Data();
        }
    }
}