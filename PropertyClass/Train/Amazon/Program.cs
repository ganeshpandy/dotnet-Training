namespace Amazon
{
    class SignIn {
        public string emailId { get; set; }
        public long mobileNo { get; set; }
    }
    class CreateAccount {
        public string yourName { get; set; }
        public long mobileNo { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
    class AmazonOrder {
        public string search { get; set; }
    }
    
    class ProductDetails {
        public string mobileName { get; set; }
        public string mobileModel { get; set; }
        public double price { get; set; }
    }
    class CustomerDetails {
        public string fullName { get; set; }
        public int houseNo { get; set; }
        public string area { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string oldAddress { get; set; }
        public string newAddress { get; set; }
    }
    class PaymentDetails {
       
        public enum paymentType{
            CreditOrDebit,OtherUPI, EMI, NetBanking, CODOrPOD
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}