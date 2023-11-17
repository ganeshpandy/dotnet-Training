using System.Net.Sockets;

namespace TicketBooking
{
     class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Ticket Type");
            string? TicketType = Console.ReadLine();
            Console.WriteLine("Enter Customer Name");
            string? CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Phone number");
            long Phno = long.Parse(Console.ReadLine());
            
            //Object
            Ticket ticket = new Ticket(TicketType, CustomerName, Phno);
            //File Location
            //string FilePath = "";
            //CreateFile(FilePath);
            string FilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Ticket.txt";
            //FileStream f = System.IO.File.Create(FilePath);

            string ticketData = "TicketType:" + ticket.TicketType + "\n CustomerName:" + ticket.CustomerName +
                "\n Phone Number:" + ticket.Phno;

            System.IO.File.WriteAllText(FilePath, ticketData);
            ticket.Type(TicketType);
            //Console.WriteLine("Data Created:\n" + ticketData);
        }
        /*public void CreateFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                FilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Ticket.txt";
                Console.WriteLine("File created");
            }
            else
            {
                Console.WriteLine("File Exists");
            }
        }*/

        }
    }
    class Ticket {
        public string? TicketType { get; set; }
        public string? CustomerName { get; set; }
        public long Phno { get; set;}
        public Ticket(string TicketType,string CustomerName,long Phno) {
            this.TicketType = TicketType;
            this.CustomerName = CustomerName;
            this.Phno = Phno;
        }
        public void Type(string TicketType)
        {
            Console.WriteLine("Enter ur Operation:-Copy/Replace/Delete/Append");
            string choice=Console.ReadLine();
            switch(choice.ToLower())
            {
                case "replace":
                    Console.WriteLine("Enter the new Type:");
                    string? ChangeType = Console.ReadLine();
                    string existingContent = $"TicketType:{TicketType}\nCustomerName:{CustomerName}\nPhoneNumber:{Phno}";                    
                    string modifiedContent = existingContent.Replace($"TicketType:{TicketType}", $"TicketType:{ChangeType}");
                    System.IO.File.WriteAllText("path.txt", modifiedContent);

                    Console.WriteLine("Data Replaced:\n" + modifiedContent);
                    break;
                case "delete":
                    File.Delete("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\CopiedData.txt");
                    Console.WriteLine("File Has Been Deleted");
                    break;
                case "copy":
                    System.IO.File.Copy ("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\TicketBooking\\bin\\Debug\\net6.0\\path.txt", "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\CopiedData.txt");
                    string CopiedData = "TicketType:" + TicketType + "\n CustomerName:" + CustomerName +
                        "\n Phone Number:" + Phno;
                        Console.WriteLine("Data Copied:\n" + CopiedData);
                    break;
                case "Append":

                    string ticketData = "TicketType:" + TicketType + "\n CustomerName:" + CustomerName +
                        "\n Phone Number:" + Phno;
                    System.IO.File.AppendAllText("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Ticket.txt", ticketData);
                    break;

            }

        }
    }

