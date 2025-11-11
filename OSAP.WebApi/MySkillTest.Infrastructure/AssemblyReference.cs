using Microsoft.Extensions.DependencyInjection;
using MySkillTest.Application.Abstractions.Iidentity;
using MySkillTest.Application.Abstractions.Jwt;
using MySkillTest.Infrastructure.Idenitity;
using MySkillTest.Infrastructure.Jwt;

namespace MySkillTest.Infrastructure
{
    public static class AssemblyReference
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<IJwtProvider, JwtProvider>();
            services.AddScoped<IContextService,ContextService>();
            return services;
        }

    }
}
