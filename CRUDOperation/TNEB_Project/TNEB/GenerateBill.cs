using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNEB
{
     class GenerateBill: Bill
    {
        public void Check()
        {
            while (true)
            {
                Console.WriteLine("Are You New Customer if Press 'Y' or else 'N' ");
                char option = char.Parse(Console.ReadLine()!.ToUpper());
                if (option == 'Y')
                {
                    CreateCustomer();
                    Console.WriteLine("Data created");
                    break;
                }
                else if (option == 'N')
                {

                    Bill bill = new Bill();
                    List<Bill> billList =bill.Getbill();

                    bill.Calculate(billList);
                    bill.Read();
                }
                else 
                {
                    Console.WriteLine("Press Y or N");
                }
                Console.WriteLine("1.For Update Customer Details\n"+"2.For Generate New Bill\n"+"3.For Delete");
                int opinion=int.Parse(Console.ReadLine()!);
                if (opinion == 1)
                {
                    Update();
                }
                else if (opinion == 2)
                {
                    UpdateBill();
                }
               
            }            
        }
        /*public bool DoesExist(int customerId)
        {
            foreach (var data in list) 
            {
                if(data.EBID == customerId) 
                { 

                    return true; 
                }
                return false;
            }
            //return customerList.Any(customer => customer.EBID == customerId);
        }*/

        //public bool Find(int id)
        //{
        //    foreach (var item in EBID)
        //    {
        //        if (item.EBID == id)
        //        {
        //            newDetail = item;
        //            return true;
        //        }
        //    }
        //    return false;
        //}

    }
}
