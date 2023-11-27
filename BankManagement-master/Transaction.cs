using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class Transaction : AccountList
    { 
        public int AccountNumber {  get; set; }
        public string TransactionType {  get; set; }

        public double StoreAmount { get; set; } 
        public double TotalBalance {  get; set; } 

        List<Transaction> transactions = new List<Transaction>();
        
        Transaction transaction = null, StoreTransaction = null;
        
        int x = 0;
        public Transaction() { }

        public void Deposit()
        {
            try
            {
                bool check = true;
                while(check)
                {
                    Console.Clear();

                    Console.WriteLine("Deposit Amount Should Be 100 Multiple !");
                    
                    Console.Write("Enter Account Number   -  ");
                    int AccountNumber = int.Parse(Console.ReadLine());

                    if (FindAccount(AccountNumber))
                    {
                        Console.Write("Enter Deposit Amount  -  ");

                        int DepositAmount = int.Parse(Console.ReadLine());

                        if (DepositAmount % 100 != 0)
                            continue;

                        if (x == 0)
                        {
                            StoreAmount = StoreAccount.Inital_Balance;
                        }
                        x++;
                        StoreAccount.Inital_Balance +=  DepositAmount;

                        transaction = new Transaction();

                        transaction.AccountNumber = StoreAccount.AccountNumber;

                        transaction.TransactionType = DepositAmount + " ( D )";

                        transaction.TotalBalance = StoreAccount.Inital_Balance;

                        AddTransAccount(transaction);

                        Console.WriteLine("Amount Deposited Successfully !!");
                    }
                    else
                    {
                        Console.WriteLine("No Account Found !!");
                    }

                    check = false;
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddTransAccount(Transaction transaction)
        {
            transactions.Add(transaction);
        }
        
        public void Withdrawal()
        {
            try
            {
                bool check = true;

                while (check)
                {
                    Console.Clear();

                    Console.Write("Enter Account Number   -  ");
                    int AccountNumber = int.Parse(Console.ReadLine());

                    if (FindAccount(AccountNumber))
                    {

                        Console.WriteLine("Withdrawal Amount Should Be 100 Multiple !");

                        Console.Write("Enter Withdraw Amount  -  ");

                        int WithdrawAmount = int.Parse(Console.ReadLine());

                        if (WithdrawAmount % 100 != 0)
                            continue;
                        if (WithdrawAmount > StoreAccount.Inital_Balance)
                        {
                            Console.WriteLine("Insufficient Amount !");
                            Console.ReadKey();
                            continue;
                        }
                        if (x == 0)
                        {
                            StoreAmount = StoreAccount.Inital_Balance;
                        }
                        x++;
                        StoreAccount.Inital_Balance -= WithdrawAmount;

                        transaction = new Transaction();

                        transaction.AccountNumber = StoreAccount.AccountNumber;

                        transaction.TransactionType = WithdrawAmount + " ( W )";

                        transaction.TotalBalance = StoreAccount.Inital_Balance;

                        AddTransAccount(transaction);

                        Console.WriteLine("Amount Withdrawan Successfully !!");

                    }
                    else
                    {
                        Console.WriteLine("No Account Found !!");
                    }
                    check = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadOneTransaction()
        {
            if(IsCount())
            {
                Console.Write("Enter Account Number   -  ");
                int AccountNumber = int.Parse(Console.ReadLine());
                int x = 0;
                Console.Clear();
                foreach (var transaction in transactions)
                {
                    if (transaction.AccountNumber == AccountNumber)
                    {
                        if (x++ == 0)
                        {
                            Console.WriteLine("Account Number    -  " + transaction.AccountNumber);
                            Console.WriteLine("\nOld Amount  -  " + StoreAmount);
                        }
                        
                        StoreTransaction = transaction;
                        Console.WriteLine("\nTransaction Type  -  " + transaction.TransactionType);
                    }
                }

                Console.WriteLine("\nAvailable Balance    -  " + StoreTransaction.TotalBalance);
            }
            else
            {
                Console.WriteLine("Transaction List Is Empty !!");
            }
            
        }

        public bool IsCount()
        {
            if(transactions!=null && transactions.Count != 0)
            {
                return true;
            }
            return false;
        }
    }
}
