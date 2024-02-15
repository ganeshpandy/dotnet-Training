using EmployeeManagement.Application.Services;
using EmployeeManagement.Domain.Model.Company;
using EmployeeManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Repository
{
    public class CompanyRespository : ICompany
    {
        private readonly DataContext _context;

        public CompanyRespository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Company>> GetAllCompany()
        {
            return await _context.Companies.ToListAsync();
        }
        public async Task<Company> GetCompanyById(int id)
        {
            return await _context.Companies
               .FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Company> AddCompany(Company company)
        {
            var result = await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Company> UpdateCompany(Company company)
        {
            var result = await _context.Companies
                    .FirstOrDefaultAsync(C => C.Id == company.Id);
            if (result != null)
            {
                result.CompanyPhoneNumber = company.CompanyPhoneNumber;
                result.Address = company.Address;

            }
            return result;
        }
        public async Task DeleteCompany(int id)
        {
            var result = await _context.Companies
             .FirstOrDefaultAsync(C => C.Id == id);
            if (result != null)
            {
                _context.Companies.Remove(result);
                await _context.SaveChangesAsync();
            }
            
        }
    }
}
