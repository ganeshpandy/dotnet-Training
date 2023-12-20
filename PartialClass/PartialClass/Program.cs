namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                FirstName = "Virat",
                LastName = "Kohil",
                Salary = 100000,
                Gender = "Male"
            };           
            emp.DisplayEmployeeDetails();
         
        }
    }
}
