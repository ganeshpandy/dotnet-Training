namespace employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(contract.empname);
            Console.WriteLine(contract.salary);
            Console.WriteLine(contract.designation);
            contract.work();
            contract.test();
            Console.WriteLine("---------------------");
            Console.WriteLine(temporary.empname);
            Console.WriteLine(temporary.salary);
            Console.WriteLine(temporary.designation);
            temporary.work();
            temporary.eat();
            Console.WriteLine("-----------------------");
            Console.WriteLine(permanent.empname);
            Console.WriteLine(permanent.salary);    
            Console.WriteLine(permanent.designation);
            permanent.work();
            permanent.test();
        }
    }
}