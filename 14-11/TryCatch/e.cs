using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical
{
    class Bill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Amount { get; set; }
        public Bill(int id, string Name, string Address, double Amount)
        {
            this.Id = id;
            this.Name = Name;
            this.Address = Address;
            this.Amount = Amount;
        }
        public void BillDetail()
        {
            //Console.WriteLine("1st Give Append\n" + "2nd Give Replace\n" + "3rd Give Copy" + "4th Give Delete");
            Console.WriteLine("Enter ur Operation:-Copy/Replace/Delete/Append");
            string choice = Console.ReadLine();
            //C: \Users\LENOVO\Desktop\DotNet\14 - 11\Medical\Record
            switch (choice)
            {

                case "copy":
                    Console.Write("Enter the destination path for the copy: ");
                    string destinationPath = Console.ReadLine();
                    string destinationFilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Medical\\Record\\" + destinationPath + ".txt";
                    //C:\\Users\\LENOVO\\Desktop\\DotNet\\14 - 11\\Library\\Record\\
                    try
                    {
                        System.IO.File.Copy("C: \\Users\\LENOVO\\Desktop\\DotNet\\14 - 11\\Medical\\Record\\ReplaceText3.txt", destinationFilePath);
                        Console.WriteLine("File copied successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred during the copy operation: " + ex.Message);
                    }
                    break;
                case "replace":
                    System.IO.File.Replace("C: \\Users\\LENOVO\\Desktop\\DotNet\\14 - 11\\Medical\\Record\\CreateRecord.txt", "C: \\Users\\LENOVO\\Desktop\\DotNet\\14 - 11\\Medical\\Record\\ReplaceText2.txt", "C: \\Users\\LENOVO\\Desktop\\DotNet\\14 - 11\\Medical\\Record\\ReplaceText3.txt");
                    Console.WriteLine("Replaced!");
                    break;
                case "delete":
                    if (File.Exists("C:\\Users\\LENOVO\\Desktop\\DotNet\\14 - 11\\Library\\Record\\ReplaceText3.txt"))
                    {
                        System.IO.File.Delete("C:\\Users\\LENOVO\\Desktop\\DotNet\\14 - 11\\Library\\Record\\ReplaceText3.txt");
                        Console.WriteLine("Deleted");
                    }
                    else
                    {
                        Console.WriteLine("File deleted already");
                    }
                    break;
                case "append":
                    string RecordData = "Id:" + Id + "\n CustomerName:" + Name +
               "\n Address:" + Address + "\n Amount:" + Amount;
                    System.IO.File.AppendAllText("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Medical\\Record\\CreateRecord.txt", RecordData);
                    break;
            }
        }
    }
}
