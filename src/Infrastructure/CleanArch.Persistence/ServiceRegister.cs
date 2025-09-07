using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using CleanArch.Persistence.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using CleanArch.Application.Repository;
using CleanArch.Persistence.Repositories;

namespace CleanArch.Persistence
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services,IConfiguration conf) 
        {
            services.AddDbContext<CleanArchDbContext>(options =>
                options.UseSqlServer(conf.GetConnectionString("DefaultConnection")));
            return services;
        }
        public static void AddPersistenceRepo(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
        }

    }
}
