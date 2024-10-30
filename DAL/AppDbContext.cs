using BE;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=WIN-I23NE9DJF3Q;Initial Catalog=AirPak;Integrated Security=True;TrustServerCertificate=True",
                b => b.MigrationsAssembly("AirPak")
            );

            base.OnConfiguring(optionsBuilder);
        }

        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "ADMIN";

            var customer = new IdentityRole("customer");
            customer.NormalizedName = "CUSTOMER";

            modelBuilder.Entity<IdentityRole>().HasData(admin, customer);
        }

        public DbSet<Click> Clicks { get; set; }
        public DbSet<Product> Products { get; set; }
    }

}
