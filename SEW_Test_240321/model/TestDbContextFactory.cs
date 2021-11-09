using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SEW_Test_240321.model
{
    public class TestContextFactory : IDesignTimeDbContextFactory<TestDbContext>
    {
        public TestDbContext CreateDbContext(string[] args)
        {
            var properties = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var optionsBuilder = new DbContextOptionsBuilder<TestDbContext>();

            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .UseMySql(
                    properties["ConnectionStrings:DefaultConnection"],
                    new MySqlServerVersion(new Version(8, 0, 23)),
                    null
                );

            return new TestDbContext(optionsBuilder.Options);
        }
    }
}