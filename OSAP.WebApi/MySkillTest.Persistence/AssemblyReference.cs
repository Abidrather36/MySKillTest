using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Persistence.Data;
using MySkillTest.Persistence.Repositories;

namespace MySkillTest.Persistence
{
    public static class AssemblyReference
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IRegisteredCompanyRepository, RegisteredCompanyRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            var connectionstring = configuration.GetConnectionString(nameof(MySkillTestDbContext));
            services.AddDbContext<MySkillTestDbContext>(options => options.UseSqlServer(connectionstring));
            services.AddScoped<IRoleRepository, RoleRepository>();
            return services;
        }
    }
}
