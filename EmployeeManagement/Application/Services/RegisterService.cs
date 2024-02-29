using EmployeeManagement.Application.Features.Handlers.QueryHandler;
using EmployeeManagement.Application.Features.Queries;
using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Services
{
    public static class RegisterService
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            //services.AddTransient<IQueryHandler<GetEmployee, IEnumerable<Employee>>,GetEmployeeHanlder>();
          
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            


            services.AddMediatR(ctg =>
            {
                ctg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });
            return services;
        }
       /* public static void ConfigureServices(IServiceCollection services)
        {
            // Register application services
            //services.AddTransient<IEmployee, Employee>();
            services.AddMediatR(typeof(RegisterService).Assembly);

            // Register infrastructure services
            //services.AddTransient<IEmployee, EmployeeRespository>();

            // Add MVC services
            //services.AddControllers();
        }*/
    }
}
