using System.Windows.Markup;

namespace CRUD
{
    public class SelectOption : EmployeeDetails
    {
        public void ChooseOption()
        {
            while (true)
            {
                Console.WriteLine(
                    "Choose Operation : \n" +
                    "i)     Create \n" +
                    "ii)    Read \n" +
                    "iii)   Update \n" +
                    "iv)    Delete\n" +
                    "v)     Exit"
                    );
                string? option = Console.ReadLine();

                if(option == "Exit")
                {
                    Console.WriteLine();
                    break;
                }
                else if(option == "Create")
                {
                    GetEmployees();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(option == "Read")
                {
                    ReadEmployee();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(option == "Update")
                {
                    UpdateEmployee();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(option == "Delete")
                {
                    DeleteRecords();
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
