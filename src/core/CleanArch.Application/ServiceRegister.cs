using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Application
{
    public static class ServiceRegister 
    {
       public static void AddApplicationRegistration(this IServiceCollection services) 
       {
            var assm = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assm);
            services.AddMediatR(cfg => { cfg.RegisterServicesFromAssembly(assm); }); 
       }
    }
}
