using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleApp.Identity
{
    public class ApplicationIdentityUser : IdentityUser
    {

    }
    public class ApplicationIdentityDbContext : IdentityDbContext<ApplicationIdentityUser>
    {
        public ApplicationIdentityDbContext(
            DbContextOptions<ApplicationIdentityDbContext> options
            ) : base(options)
        {
        }
    }

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {

            services.AddDbContext<ApplicationIdentityDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString(nameof(ApplicationIdentityDbContext).Replace(nameof(DbContext), "")))
                );

            services.AddDefaultIdentity<ApplicationIdentityUser>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>();

            // services.AddAuthentication(options =>
            // {
            //     options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //     options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            // })
            //.AddJwtBearer(options =>
            //{
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //        ValidateLifetime = true,
            //        ValidateIssuerSigningKey = true,
            //        ValidIssuer = "YourIssuer",
            //        ValidAudience = "YourAudience",
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("YourSigningKey"))
            //    };
            //});

            return services;
        }
    }
}
