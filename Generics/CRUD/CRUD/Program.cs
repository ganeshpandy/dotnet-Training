namespace CRUD
{
     class Program
    {
        static void Main(string[] args)
        {
            
            AddEmployee addemployee = new AddEmployee();
            
            addemployee.CreateEmployee();
            addemployee.Display();


        }
    }
}
