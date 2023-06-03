using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace ExampleApp.Identity
{

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {

            services.AddDbContext<ApplicationIdentityDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString(ApplicationIdentityDbContext.Schema))
                );

            services.AddDefaultIdentity<ApplicationIdentityUser>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
           .AddJwtBearer(options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   //ValidIssuer = "YourIssuer",
                   //ValidAudience = "YourAudience",
                   //IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("YourSigningKey"))
               };
           });

            return services;
        }
    }
}
