using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace WillMax.Infra.Dta
{
    internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        static string? connectionString = null; 

        static ApplicationDbContextFactory()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(".").ToString())
                .AddJsonFile("WillMax.WebApi/appsettings.Development.json", true, true)
                .Build();

            connectionString = config["ConnectionStrings:WillMaxCS"];
            Console.WriteLine("ConnectionString:" + connectionString);
        }
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer(connectionString);      
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
