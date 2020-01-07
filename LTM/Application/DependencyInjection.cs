using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using DataLayer;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddDataLayer();
            return services;
        }           
    }
}