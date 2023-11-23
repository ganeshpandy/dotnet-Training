namespace CRUD
{
    public class EmployeeDetails : GetEmployee
    {
        List<GetEmployee> employees = new List<GetEmployee>();
        public List<GetEmployee> GetEmployees()
        {
            GetEmployee employee = new GetEmployee();

            Console.Write("Enter Employee ID : ");
            employee.EmployeeId = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name : ");
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Enter Employee Address : ");
            employee.EmployeeAddress = Console.ReadLine();

            Console.Write("Enter Employee Email : ");
            employee.EmployeeEmail = Console.ReadLine();

            Console.Write("Enter Employee Phone Number : ");
            employee.PhoneNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter Employee Date Of Birth : ");
            employee.DateOfBirth = DateOnly.Parse(Console.ReadLine());

            Console.Write("Enter Employee Reporting Time : ");
            employee.ReportingTime = TimeOnly.Parse(Console.ReadLine());

            Console.Write("If Full time, enter true and if Part time enter false : ");
            employee.Timimg = bool.Parse(Console.ReadLine());

            Console.Write("Enter Salary : ");
            employee.Salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Bonus : ");
            employee.Bonus = decimal.Parse(Console.ReadLine());

            GetEmployee getEmployee = new GetEmployee
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                EmployeeAddress = employee.EmployeeAddress,
                EmployeeEmail = employee.EmployeeEmail,
                PhoneNumber = employee.PhoneNumber,
                DateOfBirth = employee.DateOfBirth,
                ReportingTime= employee.ReportingTime,
                Timimg = employee.Timimg,
                Salary= employee.Salary,
                Bonus= employee.Bonus
            };
            employees.Add(getEmployee);
            Console.WriteLine("Employee details created!");
            return employees;
        }
        public void ReadEmployee()
        {
            if(employees != null && employees.Count > 0)
            {
                foreach (var company in employees)
                {
                    Console.WriteLine(
                                "Employee Details - " + "\n" +
                                "Employee Id            : " + company.EmployeeId + "\n" +
                                "Employee Name          : " + company.EmployeeName + "\n" +
                                "Employee Address       : " + company.EmployeeAddress + "\n" +
                                "Employee Email         : " + company.EmployeeEmail + "\n" +
                                "Phone Number           : " + company.PhoneNumber + "\n" +
                                "Date Of Birth          : " + company.DateOfBirth + "\n" +
                                "Reporting Time         : " + company.ReportingTime + "\n" +
                                "Timimg                 : " + company.Timimg + "\n" +
                                "Salary                 : " + company.Salary + "\n" +
                                "Bonus                  : " + company.Bonus + "\n"
                                );
                }
            }
            else
            {
                Console.WriteLine("No details found!, please enter details");
            }
        }
        public void UpdateEmployee()
        {
            Console.Write("Enter Employee ID to update: ");
            int employeeIdToUpdate = int.Parse(Console.ReadLine());

            GetEmployee existingEmployee = null;

            foreach (var emp in employees)
            {
                if (emp.EmployeeId == employeeIdToUpdate)
                {
                    existingEmployee = emp;
                    break;
                }
            }
            if (existingEmployee != null)
            {
                Console.Write("Enter New Employee Name: ");
                existingEmployee.EmployeeName = Console.ReadLine();

                Console.Write("Enter New Employee Address: ");
                existingEmployee.EmployeeAddress = Console.ReadLine();

                Console.Write("Enter New Employee Email : ");
                existingEmployee.EmployeeEmail = Console.ReadLine();

                Console.Write("Enter New Employee Phone Number : ");
                existingEmployee.PhoneNumber = long.Parse(Console.ReadLine());

                Console.Write("Enter New Employee Date Of Birth : ");
                existingEmployee.DateOfBirth = DateOnly.Parse(Console.ReadLine());

                Console.Write("Enter New Employee Reporting Time : ");
                existingEmployee.ReportingTime = TimeOnly.Parse(Console.ReadLine());

                Console.Write("If Full time, enter true and if Part time enter false : ");
                existingEmployee.Timimg = bool.Parse(Console.ReadLine());

                Console.Write("Enter New Salary : ");
                existingEmployee.Salary = double.Parse(Console.ReadLine());

                Console.Write("Enter New Bonus : ");
                existingEmployee.Bonus = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Employee details updated!");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }
        public void DeleteRecords()
        {
            Console.WriteLine("Enter clear to delete all records or delete a specific record!");
            string? option = Console.ReadLine();

            if (employees != null && employees.Count > 0)
            {
                if (option == "Clear")
                {
                    employees.Clear();
                    Console.WriteLine("All records deleted!");
                }
            }
            else
            {
                Console.WriteLine("Delete failed, No records found!");
            }
        }
    }
}
