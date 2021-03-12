using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
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
            return services;
        }
    }
}
