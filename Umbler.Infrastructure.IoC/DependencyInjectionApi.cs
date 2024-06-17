using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Umbler.Application.Interfaces;
using Umbler.Application.Mappings;
using Umbler.Application.Services;
using Umbler.Domain.Interfaces;
using Umbler.Infrastructure.Repositories;

namespace Umbler.Infrastructure.IoC
{
    public static class DependencyInjectionApi
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddHttpClient<CieloTransactionRepository>();

            services.AddScoped<ICieloTransactionRepository, CieloTransactionRepository>();
            services.AddScoped<ICieloTransactionService, CieloTransactionService>();
            
            services.AddAutoMapper(typeof(DomainToDtoMappingProfile));

            return services;
        }
    }
}
