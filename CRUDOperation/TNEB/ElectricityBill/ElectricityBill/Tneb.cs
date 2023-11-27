using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
     class Tneb:GenrateBill<T>
    {
        public void ChooseOption()
        {
            while (true)
            {
                Console.WriteLine("Choose Operation ");
                Console.WriteLine("1.CreateCustomer");
                Console.WriteLine("2.CreateBill");
                Console.WriteLine("3.Read");
                Console.WriteLine("4.Update");
                Console.WriteLine("5.Delete");
                Console.WriteLine("6.Exit");
                int option =int.Parse(Console.ReadLine()!);

                switch (option)
                {
                    case 1:
                        CreateCustomer();
                        Console.WriteLine("Data created");
                        break;
                    case 2:
                        CreateBill();
                        Console.WriteLine("Bill Generated");
                        break;
                    case 3:
                        CreateBill();
                        Console.WriteLine("Data created");
                        break;
                    case 4:
                        Read();
                        break;
                    case 5:
                        Delete();
                        break;
                    case 6:
                        Exit();
                        break;

                }
            }
        }
    }
}
