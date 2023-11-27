using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeByInterface
{
     class CRUDOperation:SaveEmployee
    {
            public void Display()
            {
                while (true)
                {
                    Console.WriteLine("Enter the option\n" + "1.Create\n" + "2.Update\n" + "3.Read\n" + "4.Delete");
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Create();
                            Console.WriteLine("Data created");
                            break;
                        case 2:
                            Update();
                            break;
                        case 3:
                            Read();
                            break;
                        case 4:
                            Delete();
                            break;

                    }
                    //Console.ReadKey();
                }
            }
    }
}
