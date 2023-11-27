using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class Account
    {
        public  int AccountNumber { get; set; } = 100;
        public string Accounter_Name { get; set; }
        public string Accounter_Email { get; set; }
        public DateTime DOB { get; set; }
        public string Address {  get; set; }
        public string City { get; set; }
        public long PhoneNumber {  get; set; }
        public long Aadhaar_Number {  get; set; }
        public string PAN_Number {  get; set; }
        public double Inital_Balance {  get; set; }  
    }
}
