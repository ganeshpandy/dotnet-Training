using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class AccountList
    {
        public static List<Account> accounts = null;

        public static Account StoreAccount = null;
        public static bool Allow { get; set; }

        public AccountList()
        {
            if(accounts == null)
            {
                accounts = new List<Account>();
            }
        }

        public void AccountInput()
        {
            try
            {
                char x ; int c = 0;
                do
                {
                    Account account = new Account();

                    account.AccountNumber+=c;

                    Console.Write("Enter Accounter Name          :  ");
                    account.Accounter_Name = Console.ReadLine();

                    Console.Write("Enter Accounter Email         :  ");
                    account.Accounter_Email = Console.ReadLine();

                    Console.Write("Enter Accounter DateOfBirth   :  ");
                    account.DOB = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Enter Accounter Address       :  ");
                    account.Address = Console.ReadLine();

                    Console.Write("Enter Accounter City          :  ");
                    account.City = Console.ReadLine();

                    Console.Write("Enter Accounter Phone Number  :  ");
                    account.PhoneNumber = long.Parse(Console.ReadLine());

                    Console.Write("Enter Aadhaar Number          :  ");
                    account.Aadhaar_Number = long.Parse(Console.ReadLine());

                    Console.Write("Enter PAN Number              :  ");
                    account.PAN_Number = Console.ReadLine();

                    IsBalance(account);

                    Create(account);

                    Console.Clear();

                    Console.Write("\n\n\t  Type [ Y ] TO Add New Account [ N ] To Skip  ~  ");

                    x = char.Parse(Console.ReadLine());

                    c++;
                }
                while (x != 'N');
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void IsBalance(Account account)
        {
            try
            {
                bool check = true;

                while (check)
                {
                    Console.WriteLine("Initial Balance Should be Above 800 !");
                    Console.Write("Enter Initial Balance  -  ");
                    account.Inital_Balance = double.Parse(Console.ReadLine());

                    if (account.Inital_Balance < 800)
                        continue;
                    check = false;
                }
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e.Message); 
            }

        }
        public void Create(Account account)
        {
            try
            {
                Allow = true;
                accounts.Add(account);
                Console.WriteLine("Account Added Successfully !!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }

        public void Read()
        {
            try
            {
                if(IsContain())
                {                    
                    foreach (var account in accounts)
                    {
                        Console.Clear();
                        Console.WriteLine("Account Number         :  " + account.AccountNumber);
                        Console.WriteLine("Accounter Name         :  " + account.Accounter_Name);
                        Console.WriteLine("Accounter Email        :  " + account.Accounter_Email);
                        Console.WriteLine("Accounter DOB          :  " + account.DOB.ToString("dd-MM-yyyy"));
                        Console.WriteLine("Accounter Address      :  " + account.Address);
                        Console.WriteLine("Accounter City         :  " + account.City);
                        Console.WriteLine("Accounter Phone No     :  " + account.PhoneNumber);
                        Console.WriteLine("Accounter Aadhar No    :  " + account.Aadhaar_Number);
                        Console.WriteLine("Accounter PAN Number   :  " + account.PAN_Number);
                        Console.WriteLine("Accounter Balance      :  " + account.Inital_Balance);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("List Is Empty !!");
                }
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message); 
            }
            
        }

        public void Update()
        {
            try
            {
                if(IsContain())
                {
                    Console.Write("Enter Account Number   -  ");
                    int AccountNumber = int.Parse(Console.ReadLine());
                    if (FindAccount(AccountNumber))
                    {
                        int No = Change();
                        switch (No)
                        {
                            case 1:
                                Console.Write("Enter New Email  :  ");
                                StoreAccount.Accounter_Email = Console.ReadLine();
                                break;

                            case 2:
                                Console.Write("Enter New Phone Number  :  ");
                                StoreAccount.PhoneNumber = long.Parse(Console.ReadLine());
                                break;

                            case 3:
                                Console.Write("Enter New Address  :  ");
                                StoreAccount.Address = Console.ReadLine();
                                break;

                            case 4:
                                Console.Write("Enter New City Name  :  ");
                                StoreAccount.City = Console.ReadLine();
                                break;
                        }
                        if(No>=1 && No<=4)
                        {
                            Console.WriteLine("Updated Successfully !!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Check Your Account Number !!");
                    }
                }
                else
                {
                    Console.WriteLine("List Contains No Object !!");
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            
            }
        }

        public void Delete()
        {
            try
            {
                if(IsContain())
                {
                    Console.Write("Enter Account Number   -  ");
                    int AccountNumber = int.Parse(Console.ReadLine());

                    if (FindAccount(AccountNumber))
                    {
                        accounts.Remove(StoreAccount);
                        Console.WriteLine("Account Deleted Successfully !!");
                    }
                    else
                    {
                        Console.WriteLine("No Account Found !!");
                    }
                }
                else
                {
                    Allow = false;
                    Console.WriteLine("List Is Empty !!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public int Change()
        {
            Console.Clear();
            int No = 0;
            try
            {
                Console.WriteLine("==========================");
                Console.WriteLine("        UPDATE            ");
                Console.WriteLine("==========================");
                Console.WriteLine(" 1.  EMAIL                ");
                Console.WriteLine(" 2.  PHONE NUMBER         ");
                Console.WriteLine(" 3.  ADDRESS              ");
                Console.WriteLine(" 4.  CITY                 ");
                Console.WriteLine("==========================\n");
                Console.Write("Enter Your Option  ~  ");
                No = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return No;

        }
        public bool IsContain()
        {
            if(accounts != null && accounts.Count != 0)
            {
                return true;
            }
            Allow = false;
            return false;
        }
        public bool FindAccount(int AccountNumber)
        {
            Console.Clear();
            if (IsContain())
            {
                
                foreach (var account in accounts)
                {
                    if (account.AccountNumber == AccountNumber)
                    {
                        StoreAccount = account;
                        return true;
                    }
                }
                return false;
            }
            return false;

        }
    }
}
