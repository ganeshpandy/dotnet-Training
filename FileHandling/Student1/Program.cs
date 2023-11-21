namespace Student1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter StudentId");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter StudentName");
            string? Name = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string? Address = Console.ReadLine();

            Console.WriteLine("SchoolName");
            string? SchoolName = Console.ReadLine();

            Data data = new Data(Id, Name, Address, SchoolName);
        //C: \Users\LENOVO\Desktop\DotNet\14 - 11\Student1\Record
            string FilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Student1\\Record\\CreateRecord.txt";

            string RecordData = "Id:" + Id + "\n CustomerName:" + Name +
               "\n Address:" + Address + "\n SchoolName:" + SchoolName;

            System.IO.File.WriteAllText(FilePath, RecordData);
            Console.WriteLine("Data Created:\n" + RecordData);
            data.Details();

        }
    }
}