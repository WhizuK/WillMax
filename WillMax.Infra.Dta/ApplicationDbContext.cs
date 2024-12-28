using Microsoft.EntityFrameworkCore;
using WillMax.Domain;


namespace WillMax.Infra.Dta
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Apartament> Apartamentes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }

   
        public ApplicationDbContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             // Relacionamento 1:N (do lado da Location)

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.Entity<Apartament>()
                .HasOne(a => a.Location)  // Relacionamento 1:1
                .WithMany(l => l.Apartaments);

            //modelBuilder.Entity<Apartament>()
        }
    }
}
