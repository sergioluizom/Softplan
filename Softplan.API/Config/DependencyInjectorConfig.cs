using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Softplan.Domain.Services.Implementation;
using Softplan.Domain.Services.Interfaces;
using Softplan.Infra;
using Softplan.Infra.Implementation;
using Softplan.Infra.Interfaces;

namespace Softplan.API.Config
{
    public static class DependencyInjectorConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ITokenService, TokenService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddDbContext<Context>();

            return services;
        }
    }
}
