using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
     class Record
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string BookName { get; set; }
        public string Date { get; set; }
        public Record(int Id,string CustomerName,string BookName, string Date) 
        {
            this.Id = Id;
            this.CustomerName = CustomerName;
            this.BookName = BookName;
            this.Date = Date;
        }
        public void Data() 
        {
            Console.WriteLine("1.Give Append\n" + "2. Give Replace\n" + "3. Give Copy\n" + "4. Give Delete");
            //Console.WriteLine("Enter ur Operation:-Copy/Replace/Delete/Append");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string RecordData = "Id:" + Id + "\n CustomerName:" + CustomerName +
               "\n BookName:" + BookName + "\n Date:" + Date;
                    System.IO.File.AppendAllText("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Ticket.txt", RecordData);
                    Console.WriteLine("Data Created:\n" + RecordData);
                    break;
                case 2:
                    try
                    {
                        System.IO.File.Replace("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\ReplaceText1.txt", "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\ReplaceText2.txt", "C:\\Users\\DELL\\Desktop\\NewFiles\\ReplaceText3.txt");
                        Console.WriteLine("Replaced!");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("replaced");
                    }
                    break;
                case 3:
                    Console.Write("Enter the destination path for the copy: ");
                    //string destinationPath = Console.ReadLine();
                    string destinationFilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\CopyData.txt";
                //C:\\Users\\LENOVO\\Desktop\\DotNet\\14 - 11\\Library\\Record\\CreateRecord.txt
                    try
                    {
                        System.IO.File.Copy("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\RecordData2.txt", "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\CopyData.txt");
                        Console.WriteLine("File copied successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred during the copy operation: " + ex.Message);
                    }
                    break;
                
                case 4:
                    System.IO.File.Delete("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\ReplaceText3.txt");
                    Console.WriteLine("Deleted");
                    break;
                
            }
        }

    }
}
