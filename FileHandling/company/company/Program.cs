using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Filestreampratice;
//using static System.Net.WebRequestMethods;

namespace Filestreampratice
{
        class Practice
        {
            static void Main(string[] args)
            {

                //Console.Write("Enter Name: ");
                //string? Name = Console.ReadLine();
                //Console.Write("Enter Id: ");
                //string? Id = Console.ReadLine();
                //Console.Write("Enter Email_Id: ");
                //string? Email_Id = Console.ReadLine();
                //Console.Write("Enter Address: ");
                //string? Address = Console.ReadLine();
                //Console.Write("Enter Mobile: ");
                //string? Mobile = Console.ReadLine();

                Employee employee = new Employee();
                employee.Emp("Namrata", "001", "Gmail.com", "Mint street", "945321768");
            }
        }

        class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Email_Id { get; set; }
        public string Address { get; set; }

        public string Mobile { get; set; }
        public void Emp(string Name, string Id, string Email_Id, string Address, string Mobile)
        {
            int cont;
            this.Name = Name;
            this.Id = Id;
            this.Email_Id = Email_Id;
            this.Address = Address;
            this.Mobile = Mobile;
            int ch;
            do
            {
                Console.WriteLine("Enter your choice \n1.Create\n2.Copy\n3.Delete\n4.Write\n5.Replace\n6.Append\n7.Read\n8.Exists");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Creating_File();
                        break;
                    case 2:
                        Copy_file();
                        break;
                    case 3:
                        Deleting_file();
                        break;
                    case 4:
                        Writing_file();
                        break;
                    case 5:
                        Replacing_file();
                        break;
                    case 6:
                        Append_file();
                        break;
                    case 7:
                        Read_file();
                        break;
                    case 8:
                        Exist_file();
                        break;
                    default:
                        Console.WriteLine("invalid choice.....");
                        break;
                }
                Console.WriteLine("Press 1 to continue....");
                cont = int.Parse(Console.ReadLine());
            } while (cont == 1);

        }

        public void Creating_File()
        {
            string Employe = "C:\\DEMOPROJECTS\\Demo\\Employee.txt";
            File.Create(Employe).Close();

        }
        public void Replacing_file()
        {
            string Employe = "C:\\DEMOPROJECTS\\Demo\\Employee.txt";
            string file2 = "C:\\DEMOPROJECTS\\Demo\\Info.txt";
            //File.Copy(Employe, file2);

            //string Employe = "C:\\DEMOPROJECTS\\Demo\\Employee.txt";
            //File.Create(Employe).Close();

            string file3 = "C:\\DEMOPROJECTS\\Demo\\Backup.txt";
            File.Replace(Employe, file2, file3);

        }
        public void Deleting_file()
        {
            string Employe = "C:\\DEMOPROJECTS\\Demo\\Employee.txt";
            File.Delete(Employe);
            string file1 = "C:\\DEMOPROJECTS\\Demo\\Employee";
            File.Delete(file1);
            string file2 = "C:\\DEMOPROJECTS\\Demo\\Info.txt";
            File.Delete(file2);
            string file3 = "C:\\DEMOPROJECTS\\Demo\\Backup.txt";
            File.Delete(file3);

        }
        public void Writing_file()
        {
            string Employe = "C:\\DEMOPROJECTS\\Demo\\Employee.txt";
            //File.WriteAllText(Employe + "\n", "Vrushali");
            //File.WriteAllText(Employe + "\n","002");
            //File.WriteAllText(Employe + "\n", "Yahoo");
            //File.WriteAllText(Employe + "\n", "Ganesh Nagar");
            //File.WriteAllText(Employe + "\n", "987634567");
            File.WriteAllText("C:\\DEMOPROJECTS\\Demo\\Employee.txt", "\nVrushali\n002\nYahoo\n98243475683534");
            //File.WriteAllText("C:\\DEMOPROJECTS\\Demo\\Employee.txt", "\n002");
            //File.WriteAllText("C:\\DEMOPROJECTS\\Demo\\Employee.txt", "\nYahoo");
            //File.WriteAllText("C:\\DEMOPROJECTS\\Demo\\Employee.txt", "\n98243475683534");


        }
        public void Append_file()
        {
            string Employe = "C:\\DEMOPROJECTS\\Demo\\Employee.txt";
            File.AppendAllText(Employe, "\n" + Name);
            File.AppendAllText(Employe, "\n" + Id);
            File.AppendAllText(Employe, "\n" + Email_Id);
            File.AppendAllText(Employe, "\n" + Address);
            File.AppendAllText(Employe, "\n" + Mobile);
            // string Display = File.ReadAllText(Employe);
        }
        static void Copy_file()
        {
            string Employe = "C:\\DEMOPROJECTS\\Demo\\Employee.txt";
            //
            //File.Create(Employe).Close();

            string file2 = "C:\\DEMOPROJECTS\\Demo\\Info.txt";
            File.Copy(Employe, file2);


        }
        public void Read_file()
        {
            string Employe = "C:\\DEMOPROJECTS\\Demo\\Employee.txt";
            string Display = File.ReadAllText(Employe);
            Console.WriteLine(Display);

            string file2 = "C:\\DEMOPROJECTS\\Demo\\Info.txt";
            Console.WriteLine(File.ReadAllText(file2));

        }
        public void Exist_file()
        {
            string Employe = "C:\\DEMOPROJECTS\\Demo\\Employee.txt";
            if (File.Exists(Employe))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("file do not exist");
            }

        }


    }

}