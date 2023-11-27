using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AccountList accountList = new AccountList();
            Transaction transaction = new Transaction();
            while (true)
            {
                Console.Clear();
                int Option = Menu();
                switch(Option)
                {
                    case 1: accountList.AccountInput();
                        break;

                    case 2: accountList.Read();
                        break;

                    case 3: accountList.Update();
                        break;

                    case 4: accountList.Delete();
                            accountList.IsContain();
                        break;

                    case 5: 
                            if(AccountList.Allow)
                                transaction.Deposit();
                        break;

                    case 6:
                        if (AccountList.Allow)
                            transaction.Withdrawal();
                        break;

                    case 7:
                        if (AccountList.Allow)
                                transaction.ReadOneTransaction();
                        break;
                }
                Console.ReadKey();
                if (Option > 7)
                    break;
            }
            

        }

        public static int Menu()
        {
            int option = 0, x = 1 ;
            try
            {
                Console.WriteLine("* * * * * * * * * * * * * * * * * *");
                Console.WriteLine("         CRUD OPERATION            ");
                Console.WriteLine("* * * * * * * * * * * * * * * * * *");
                Console.WriteLine(x++ +".    CREATE                  ");
                Console.WriteLine(x++ + ".    READ                    ");
                Console.WriteLine(x++ + ".    UPDATE                  ");
                Console.WriteLine(x++ + ".    DELETE                  ");
                if(AccountList.Allow)
                {
                    Console.WriteLine(x++ + ".    DEPOSIT                 ");
                    Console.WriteLine(x++ + ".    WITHDRAW                ");
                    Console.WriteLine(x++ + ".    TRANSACTION DETAIL      ");
                }
                Console.WriteLine("* * * * * * * * * * * * * * * * * *\n");
                Console.Write("ENTER YOUR OPTION  >  ");
                option = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return option;
        }
    }
}
