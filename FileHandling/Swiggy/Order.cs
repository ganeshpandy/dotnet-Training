using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiggy
{
    class Order
    {
        public string? HotelName{ get; set; }
        public string? FoodItem { get; set; }        
        public string? OrderQty { get; set; }
        public double Price { get; set; }
        public string? Address { get; set; }

        public Order(string HotelName, string FoodItem, string OrderQty, double Price, string Address)
        {
            this.HotelName = HotelName;
            this.FoodItem = FoodItem;            
            this.OrderQty = OrderQty;
            this.Price = Price;
            this.Address = Address;
        }
        //C:\Users\LENOVO\Desktop\DotNet\14-11\Swiggy\Files
        public void Details() 
        {
            Console.WriteLine("Enter ur Operation:-Copy/Replace/Delete/Append");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "copy":
                    Console.Write("Enter the destination path for the copy: ");
                    string destinationPath = Console.ReadLine();
                    string destinationFilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Swiggy\\Files" + destinationPath + ".txt";
                    
                    try
                    {
                        System.IO.File.Copy("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Swiggy\\Files\\RecordData2.txt", destinationFilePath);
                        Console.WriteLine("File copied successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred during the copy operation: " + ex.Message);
                    }
                    break;
                case "replace":
                    System.IO.File.Replace("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Swiggy\\Files\\ReplaceText1.txt", "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Swiggy\\Files\\ReplaceText2.txt", "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Swiggy\\Files\\ReplaceText3.txt");
                    Console.WriteLine("Replaced!");
                    break;
                case "delete":
                    System.IO.File.Delete("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Swiggy\\Files\\ReplaceText3.txt");
                    Console.WriteLine("Deleted");
                    break;
                case "append":
                    string RecordData = "Id:" + Id + "\n CustomerName:" + CustomerName +
               "\n BookName:" + BookName + "\n Date:" + Date;
                    System.IO.File.AppendAllText("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Ticket.txt", RecordData);
                    break;
            }
        }

    }
}
