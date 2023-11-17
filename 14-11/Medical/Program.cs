namespace Medical
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter BillId");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter CustomerName");
            string? Name = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string? Address = Console.ReadLine();

            Console.WriteLine("Amount");
            double Amount=double.Parse(Console.ReadLine());

            Bill bill = new Bill(Id, Name, Address, Amount);
        //C: \Users\LENOVO\Desktop\DotNet\14 - 11\Medical\Record
            string FilePath = "C: \\Users\\LENOVO\\Desktop\\DotNet\\14 - 11\\Medical\\Record\\CreateRecord.txt";
            FileStream f = System.IO.File.Create(FilePath);

            string RecordData = "Id:" + Id + "\n CustomerName:" + Name +
               "\n Address:" + Address + "\n Amount:" + Amount;

            System.IO.File.WriteAllText(FilePath, RecordData);
            Console.WriteLine("Data Created:\n" + RecordData);
            bill.BillDetail();
        }
    }
}