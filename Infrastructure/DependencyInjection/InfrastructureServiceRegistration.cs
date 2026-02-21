using Application.Interfaces.IRepository;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DependencyInjection
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services
            )
        {

            // Register Repositories
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
           
            return services;
        }
    }// caii
}
