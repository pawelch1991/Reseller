using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace Reseller.Infrastructure.Database.Factory
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ResellerContext>
    {
        public ResellerContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.Local.json", optional: true, reloadOnChange: true).Build();

            var builder = new DbContextOptionsBuilder<ResellerContext>();
            var connectionString = configuration.GetConnectionString("ResellerContext");
            builder.UseSqlServer(connectionString);
            return new ResellerContext(builder.Options);
        }
    }
}
