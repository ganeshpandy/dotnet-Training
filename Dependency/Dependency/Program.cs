namespace LooseCoupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Injection");
            Injection ca = new Injection(new CurrentAccount("Alex", "SBI"));
            ca.PrintAccount();

            Console.WriteLine("============================================");
            Console.WriteLine("Property Injection");
            ca.CustomerName1 = "Bala";
            ca.BankName1 = "SBI";
            ca.PrintAccount();

            //Console.WriteLine("============================================");
            //Injection sa = new Injection(new SavingAccount("Alex", "HDFC"));
            //sa.PrintAccount();

            // Example of using the InjectAccount method
            Console.WriteLine("============================================");
            Console.WriteLine("Method Injection");
            Injection methodInjection = new Injection();
            methodInjection.InjectAccount(new CurrentAccount("John", "ICICI"));
            methodInjection.PrintAccount();
        }
    }

    public interface IAccount
    {
        void PrintDetails();
    }

    class SavingAccount : IAccount
    {
        public string? CustomerName { get; set; }
        public string? BankName { get; set; }

        public SavingAccount(string _CustomerName, string _BankName)
        {
            CustomerName = _CustomerName;
            BankName = _BankName;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Saving Account");
            Console.WriteLine("Customer Name:" + CustomerName);
            Console.WriteLine("Bank Name:" + BankName);
        }
    }

    class CurrentAccount : IAccount
    {
        public string? CustomerName { get; set; }
        public string? BankName { get; set; }

        public CurrentAccount(string _CustomerName, string _BankName)
        {
            CustomerName = _CustomerName;
            BankName = _BankName;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Customer Name:" + CustomerName);
            Console.WriteLine("Bank Name:" + BankName);
            Console.WriteLine("Current Account");
        }
    }

    class Injection
    {
        // Injection
        public IAccount account;

        // Property Injection
        public string? CustomerName1 { get; set; }
        public string? BankName1 { get; set; }

        public Injection()
        {
            // Default constructor
        }

        public Injection(IAccount account)
        {
            this.account = account;
        }

        public void InjectAccount(IAccount newAccount)
        {
            account = newAccount;
        }

        public void PrintAccount()
        {
            account.PrintDetails();
            Console.WriteLine("Customer Name:" + CustomerName1);
            Console.WriteLine("Bank Name:" + BankName1);
        }
    }

}
