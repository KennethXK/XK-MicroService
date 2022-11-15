﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Business.EntityFrameworkCore
{
    public class BusinessMigrationDbContextFactory: IDesignTimeDbContextFactory<BusinessMigrationDbContext>
    {
        public BusinessMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BusinessMigrationDbContext>()
                .UseMySql(configuration.GetConnectionString("Business"), new MySqlServerVersion(new Version(8, 0, 11)));

            return new BusinessMigrationDbContext(builder.Options);
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
