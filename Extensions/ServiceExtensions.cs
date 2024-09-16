using Doracorde.API.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Doracorde.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddApiConfiguration();
        }
    }
}
