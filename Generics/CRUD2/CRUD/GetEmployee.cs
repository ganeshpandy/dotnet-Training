namespace CRUD
{
    public class GetEmployee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeAddress { get; set; }
        public string? EmployeeEmail {  get; set; }
        public long PhoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public TimeOnly ReportingTime { get; set; }
        public bool Timimg { get; set; }
        public double Salary { get; set; }
        public decimal Bonus { get; set; }
    }
}
