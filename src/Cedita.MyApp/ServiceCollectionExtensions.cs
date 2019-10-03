using $safeprojectname$.Abstractions;
using $safeprojectname$.Services;
using Microsoft.Extensions.DependencyInjection;

namespace $safeprojectname$
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            // Add any services required by this application in here

            services.AddTransient<IPrimeNumberDeterminator, PrimeNumberDeterminator>();

            return services;
        }
    }
}
