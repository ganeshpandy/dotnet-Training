using System.Windows.Markup;

namespace Employee
{
    public class CRUDOperation:EmployeeDetails
    {
        public void ChooseOption()
        {
            while (true)
            {
                Console.WriteLine("Choose Operation ");
                Console.WriteLine("1.Create");
                Console.WriteLine("2.Read");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                Console.WriteLine("5.Exit");
                int option =int.Parse(Console.ReadLine()!);

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
            }
        }
    }
}
