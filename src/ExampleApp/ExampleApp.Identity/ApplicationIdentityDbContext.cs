using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExampleApp.Identity
{
    public class ApplicationIdentityDbContext : IdentityDbContext<ApplicationIdentityUser>
    {
        public const string Schema = "ApplicationIdentity";

        public ApplicationIdentityDbContext(
            DbContextOptions<ApplicationIdentityDbContext> options
            ) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema(Schema);
        }
    }
}
