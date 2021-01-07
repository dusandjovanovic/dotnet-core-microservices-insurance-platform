using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Init
{
    public static class DataLoaderInstaller
    {
        public static IServiceCollection AddPaymentDemoInitializer(this IServiceCollection services)
        {
            services.AddScoped<DataLoader>();
            return services;
        }
    }
}
