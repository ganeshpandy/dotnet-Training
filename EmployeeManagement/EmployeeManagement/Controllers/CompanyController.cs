using EmployeeManagement.Application.Services;
using EmployeeManagement.Domain.Model.Company;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompany company;

        public CompanyController(ICompany company)
        {
            this.company = company;
        }
        [HttpGet("GetCompanies")]
        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var get = await company.GetAllCompany();
            return get;
        }
        [HttpGet("GetCompanyById")]
        public async Task<Company> GetCompanyById(int id)
        {
            var get = await company.GetCompanyById(id);
            return get;
        }
        [HttpPost("AddCompany")]
        public async Task<Company> AddStudent(Company companyDetails)
        {
            await company.AddCompany(companyDetails);
            return companyDetails;
        }
        [HttpPut("UpdateCompanyDetails")]
        public async Task<Company> UpdateStudent(Company companyDetails)
        {
            var update = await company.UpdateCompany(companyDetails);
            return update;
        }
        [HttpDelete("DeleteCompany")]
        public async Task DeleteCompany(int id)
        {
            await company.DeleteCompany(id);
        }
    }
}
