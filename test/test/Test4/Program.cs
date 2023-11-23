using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet
{
    class CompanyList
    {
        static void Main(string[] args)
        {
            company company = new company();
            company.LoadCompany();

            companyInput companyInput = new companyInput();
            Console.WriteLine("Enter ID :");
            companyInput.Id = Console.ReadLine();

            Console.WriteLine("Enter CompanyName :");
            companyInput.CompanyName = Console.ReadLine();

            Console.WriteLine("Enter Address :");
            companyInput.Address = Console.ReadLine();

            Console.WriteLine("Enter Email :");
            companyInput.Email = Console.ReadLine();

            //      company.Create(companyInput);

            company.Read();

            company.Update(companyInput);


        }
    }

    public class company
    {
        List<companyInput> listMain = new List<companyInput>();

        public void LoadCompany()
        {
            listMain = new List<companyInput>()
            {
                new companyInput(){Id="100",Address="SIS,Chennai",CompanyName="SIS",Email="sisAdmin@sisdn.com"},
                 new companyInput(){Id="101",Address="SIS-Polland",CompanyName="SIS-Polland",Email="sisPollandAdmin@sisdn.com"},
                   new companyInput(){Id="102",Address="SIS-US",CompanyName="SIS-US",Email="sisUSAdmin@sisdn.com"}
            };
        }


        public void Create(companyInput companyInput)
        {
            listMain.Add(companyInput);
            Console.WriteLine("companyInput is added");
        }

        public void Read()
        {
            foreach (var company in listMain)
            {
                Console.WriteLine("company ID:" + company.Id);
                Console.WriteLine("company Email:" + company.Email);
                Console.WriteLine("company Address:" + company.Address);
                Console.WriteLine("company CompanyName:" + company.CompanyName);
            }

        }


        public void Update(companyInput company)
        {
            for (int i = 0; i < listMain.Count; i++)
            {
                if (listMain[i].Id == company.Id)
                {
                    listMain[i].Address = company.Address;
                    listMain[i].Email = company.Email;
                    listMain[i].CompanyName = company.CompanyName;
                }
            }
        }

        public void Delete(companyInput company)
        {

        }


    }
    public class companyInput
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }


    public class EmployeeInput
    {
        public string Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeEmail { get; set; }

    }
    /*class EmployeeMain
  {
      public void Create(EmployeeInput employeeInput)
      {

      }

      public List<EmployeeInput> Read()
      {
          List<EmployeeInput> empInputs = new List<EmployeeInput>();
          return empInputs;
      }


      public void Update(EmployeeInput company)
      {

      }

      public void Delete(EmployeeInput company)
      {

      }

  }
*/

}
