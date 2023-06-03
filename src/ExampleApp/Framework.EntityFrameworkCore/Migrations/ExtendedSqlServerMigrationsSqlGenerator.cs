using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Update;
using System;

namespace ExampleApp.Identity.Extensions
{
    public class ExtendedSqlServerMigrationsSqlGenerator : SqlServerMigrationsSqlGenerator
    {
        public ExtendedSqlServerMigrationsSqlGenerator(
            MigrationsSqlGeneratorDependencies dependencies, 
            ICommandBatchPreparer commandBatchPreparer
            ) : base(dependencies, commandBatchPreparer)
        {
        }

        protected override void Generate(
            EnsureSchemaOperation operation, 
            IModel? model, 
            MigrationCommandListBuilder builder
            )
        {
            if (string.Equals(operation.Name, "dbo", StringComparison.OrdinalIgnoreCase))
                return;

            builder
                .Append("CREATE SCHEMA "+ Dependencies.SqlGenerationHelper.DelimitIdentifier(operation.Name))
                .AppendLine(Dependencies.SqlGenerationHelper.StatementTerminator)
                .EndCommand();
        }
    }
}
