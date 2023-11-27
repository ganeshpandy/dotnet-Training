using System.Net;

namespace EmployeeByInterface
{
     class Program
    {
        static void Main(string[] args)
        {
            CRUDOperation operation = new CRUDOperation();
            operation.Display();
        }
    }
}
