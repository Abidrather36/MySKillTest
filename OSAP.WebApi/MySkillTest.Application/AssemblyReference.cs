using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySkillTest.Application.Abstractions.IEmailService;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Application.Services;
using MySkillTest.Application.Utils;

namespace MySkillTest.Application
{
    public static  class AssemblyReference
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddScoped<IRegisterCompanyService, RegisterCompanyService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRoleService, UserRoleService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IRoleService, RoleService>();
            return services;
        }
    }
}
