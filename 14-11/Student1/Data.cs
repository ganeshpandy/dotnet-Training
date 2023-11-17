using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1
{
    class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string SchoolName { get; set; }
        public Data(int id,string Name,string Address,string SchoolName) 
        {
            this.Id = id;
            this.Name = Name;
            this.Address = Address;
            this.SchoolName = SchoolName;
        }
        public void Details()
        {            
            Console.WriteLine("1st Give Append\n" + "2nd Give Replace\n" + "3rd Give Copy" + "4th Give Delete");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "copy":
                    Console.Write("Enter the destination path for the copy: ");
                    string destinationPath = Console.ReadLine();
                    string destinationFilePath = "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\" + destinationPath + ".txt";
                    //C:\\Users\\LENOVO\\Desktop\\DotNet\\14 - 11\\Library\\Record\\
                    try
                    {
                        System.IO.File.Copy("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\ReplaceText3.txt", destinationFilePath);
                        Console.WriteLine("File copied successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred during the copy operation: " + ex.Message);
                    }
                    break;
                case "replace":
                    System.IO.File.Replace("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\CreateRecord.txt", "C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\ReplaceText2.txt", "C:\\Users\\DELL\\Desktop\\NewFiles\\ReplaceText3.txt");
                    Console.WriteLine("Replaced!");
                    break;
                case "delete":
                    System.IO.File.Delete("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\ReplaceText3.txt");
                    Console.WriteLine("Deleted");
                    break;
                case "append":
                    string RecordData = "Id:" + Id + "\n CustomerName:" + Name +
               "\n Address:" + Address + "\n SchoolName:" + SchoolName;
                    System.IO.File.AppendAllText("C:\\Users\\LENOVO\\Desktop\\DotNet\\14-11\\Library\\Record\\CreateRecord.txt", RecordData);
                    break;
            }
        }

    }
    }

