using System.Diagnostics;
using System.Reflection;

namespace Constructor4
{
    class PaymentOption {        
        string CreditOrDebit;
        string OtherUPI;
        string EMI;
        string NetBanking;
        string option ;

        public PaymentOption(string CreditOrDebit,string OtherUPI,string EMI,string NetBanking) { 
            this.CreditOrDebit = CreditOrDebit;
            this.OtherUPI = OtherUPI;
            this.EMI = EMI;
            this.NetBanking = NetBanking;
        }
        public void paymentType(string option,string CreditOrDebit, string OtherUPI, string EMI, string NetBanking) {           
        switch (option) {
                case "CreditOrDebit":
                    Console.WriteLine("Customer Choose to pay via Credit card");
                    break;
                case "OtherUPI":
                    Console.WriteLine("Customer Choose to pay via UPI");
                    break;
                case "EMI":
                    Console.WriteLine("Customer Choose to pay via EMI");
                    break;
                case "NetBanking":
                    Console.WriteLine("Customer Choose to pay via NetBanking");
                    break;
                 default: 
                    Console.WriteLine("invalid option");
                    break;
            }            
        }
        public void read() {
            Console.WriteLine(option);
           /* Console.WriteLine(CreditOrDebit);
            Console.WriteLine(OtherUPI);
            Console.WriteLine(EMI);
            Console.WriteLine(NetBanking);   */         
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            PaymentOption paymentOption = new PaymentOption("CreditOrDebit", "","","");      
            paymentOption.paymentType("CreditOrDebit","","","","");
            
        }
    }
}