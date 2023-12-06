namespace Medical
{
    public class SaveCustomer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }        
        public string? Place {  get; set; }
        public long PhoneNumber { get; set; }
        public DateOnly Date { get; set; }        
        public double Amount { get; set; }        
    }
}
