using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace DataLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services) 
        {             
            services.AddDbContext<LtmDataContext>(options =>
                options.UseInMemoryDatabase("ltm-db"));
            services.AddScoped<ILtmDataContext, LtmDataContext>();       
            return services;            
        }
    }
}