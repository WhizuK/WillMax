using Microsoft.EntityFrameworkCore;
using WillMax.Domain;


namespace WillMax.Infra.Dta
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Apartament> Apartamentes { get; set; }
        public DbSet<User> Users { get; set; }

   
        public ApplicationDbContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            //modelBuilder.Entity<Apartament>()
        }
    }
}
