using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Init
{
    public static class ApplicationBuilderExtensions
    {
        public static async Task UseInitializer(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var initializer = scope.ServiceProvider.GetService<DataLoader>();
                await initializer.Seed();
            }
        }
    }
}
