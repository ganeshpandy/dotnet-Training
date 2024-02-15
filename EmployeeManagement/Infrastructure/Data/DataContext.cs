using EmployeeManagement.Domain.Model.Company;
using EmployeeManagement.Domain.Model.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext() { }
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Company;Integrated Security=True;TrustServerCertificate=True;");

    }
}
