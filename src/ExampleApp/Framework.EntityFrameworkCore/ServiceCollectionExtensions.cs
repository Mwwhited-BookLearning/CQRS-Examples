using ExampleApp.Identity.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Framework.EntityFrameworkCore
{

    public static class DbContextOptionsBuilderExtensions
    {
        public static DbContextOptionsBuilder ExtendMigrations(this DbContextOptionsBuilder builder)
        {
            builder.ReplaceService<IMigrationsSqlGenerator, ExtendedSqlServerMigrationsSqlGenerator>();

            return builder;
        }
    }
}
