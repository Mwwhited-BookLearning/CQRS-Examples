

dotnet build .\ExampleApp.sln

dotnet ef dbcontext script ^
--project .\ExampleApp.Identity\ExampleApp.Identity.csproj ^
--startup-project .\ExampleApp.WebApi\ExampleApp.WebApi.csproj ^
--context ApplicationIdentityDbContext ^
--output .\ExampleApp.SqlDatabase\Generated\ApplicationIdentityDbContext.sql ^
--no-build

