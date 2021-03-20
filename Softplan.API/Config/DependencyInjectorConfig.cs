using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Softplan.Domain;
using Softplan.Domain.Repository.Implementation;
using Softplan.Domain.Repository.Interfaces;
using Softplan.Domain.Services.Implementation;
using Softplan.Domain.Services.Interfaces;

namespace Softplan.API.Config
{
    public static class DependencyInjectorConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ITokenService, TokenService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            
            return services;
        }
    }
}
