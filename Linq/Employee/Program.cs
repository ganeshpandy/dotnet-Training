namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails details = new EmployeeDetails();            

            // Load data
            List<EmployeeDetails> employeeList = EmployeeDetails.LoadEmployee();
            List<Department> departmentList = EmployeeDetails.LoadDepartment();
            List<Company> companyList = EmployeeDetails.LoadCompany();

            // Perform sorting operations
            //details.SortingOperation(employeeList, departmentList, companyList);

            // Perform join operations
            details.Join(employeeList, departmentList, companyList);

            // Perform group operations
            //details.GroupOperation(employeeList, departmentList, companyList);

            // Perform filtering operations
            //details.FilteringOperation(employeeList, departmentList, companyList);

            // Perform projection operations
            //details.ProjectionOperation(employeeList, departmentList, companyList);

            // Perform Aggregate Operation 
            //details.AggregateOperation(employeeList);

            //Perfrom Partitioning Operation
            //details.PartitionOperation(employeeList);
        }
    }
}
