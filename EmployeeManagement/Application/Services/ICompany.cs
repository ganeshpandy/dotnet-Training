using EmployeeManagement.Domain.Model.Company;
using EmployeeManagement.Domain.Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Services
{
    public interface ICompany
    {
        Task<Company> GetCompanyById(int id);
        Task<IEnumerable<Company>> GetAllCompany();
        Task<Company> AddCompany(Company company);
        Task <Company>UpdateCompany(Company company);
        Task DeleteCompany(int id);
    }
}
