namespace TightCoupling
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.PrintAccount();
        }
    }
    class SavingAccount 
    {
        public void PrintDetails()
        {
            Console.WriteLine("Saving Account");
        }
    }
    class CurrentAccount 
    {
        public void PrintDetails()
        {
            Console.WriteLine("Current Account");
        }
    }
    class Account 
    {
        CurrentAccount ca=new CurrentAccount();
        SavingAccount sa=new SavingAccount();
        public void PrintAccount() 
        {
            ca.PrintDetails();
            sa.PrintDetails();
        }
    }
}
