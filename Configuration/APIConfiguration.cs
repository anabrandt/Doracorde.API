using Microsoft.Extensions.DependencyInjection;
using Doracorde.Repository;
using Doracorde.Services;
using Doracorde.ORACLE.Context;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Doracorde.API.Configuration
{
    public static class APIConfiguration
    {
        public static void AddApiConfiguration(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseOracle("Your Oracle Connection String"));
            services.AddScoped<CursoRepository>();
            services.AddScoped<ICursoService, CursoService>();
        }
    }
}
