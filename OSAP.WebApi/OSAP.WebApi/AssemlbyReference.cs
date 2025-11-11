using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Application.Services;
namespace MySkillTest.WebApi
{
    public static class AssemlbyReference
    {
        public static IServiceCollection AddApiService(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddHttpContextAccessor();
            services.AddScoped<IUserService, UserService>();
            services.AddAuthentication(options =>
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme

            ).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateLifetime = true,
                    ValidAudience = configuration["Jwt:Audience"],
                    ValidIssuer = configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!))
                };
            }
                );
            return services;
        }

    }
}
