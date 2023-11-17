using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCTC
{
     class Booking
    {
        public string Name { get; set; }
        public string TicketId { get; set; }
        public string Date { get; set; }
        public double Price { get; set; }
        public Booking(string Name,string TicketId,string Date,double Price) 
        {
            this.Name = Name;
            this.TicketId = TicketId;
            this.Date = Date;
            this.Price = Price;
        }
        public void Change()
        {
            Console.WriteLine("Enter ur Operation:-Copy/Replace/Delete/Append");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                
                case "copy":                    
                    try
                    {
                        System.IO.File.Copy("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\IRCTC\\Booking\\CopyFile1.txt", "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\IRCTC\\Booking\\CopyFile2.txt");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "replace":
                    System.IO.File.Replace("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\IRCTC\\Booking\\ReplaceText1.txt", "C:\\Users\\DELL\\Desktop\\NewFiles\\ReplaceText2.txt", "C:\\Users\\DELL\\Desktop\\NewFiles\\ReplaceText3.txt");
                    Console.WriteLine("Replaced!");
                    break;
                case "delete":
                    if (File.Exists("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\IRCTC\\Booking\\ReplaceText3.txt"))
                    {
                        System.IO.File.Delete("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\IRCTC\\Booking\\ReplaceText3.txt");
                        Console.WriteLine("Deleted");
                    }
                    else 
                    {
                        Console.WriteLine("File doesn't Exists!");
                    }
                    break;
                case "append":
                    string BookingData = "Name:" + Name + "\n TicketId:" + TicketId +
                                        "\n Date:" + Date + "\n Price:" + Price;
                    System.IO.File.AppendAllText("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\IRCTC\\Booking\\Ticket.txt", BookingData);
                    break;
            }
        }
    }
}
