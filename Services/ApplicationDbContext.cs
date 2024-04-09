using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MPSecureVMS.Models;


namespace MPSecureVMS.Services
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options): base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var manager = new IdentityRole("manager");
            manager.NormalizedName = "manager";

            var salesperson = new IdentityRole("salesperson");
            salesperson.NormalizedName = "salesperson";

            builder.Entity<IdentityRole>().HasData(admin, manager, salesperson);
        }
        public DbSet<MPSecureVMS.Models.Vendor> Vendor { get; set; } = default!;

    }
}
