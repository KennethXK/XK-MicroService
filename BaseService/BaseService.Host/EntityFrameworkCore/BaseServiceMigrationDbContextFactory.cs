using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace BaseService.EntityFrameworkCore
{
    public class BaseServiceMigrationDbContextFactory : IDesignTimeDbContextFactory<BaseServiceMigrationDbContext>
    {
        public BaseServiceMigrationDbContext CreateDbContext(string[] args)
        {
            BaseEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BaseServiceMigrationDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"), new MySqlServerVersion(new Version(8, 0, 11)));

            return new BaseServiceMigrationDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
