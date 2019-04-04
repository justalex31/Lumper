using Lumper.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lumper.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions options)
              : base(options)
        {
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserRating> UserRatings { get; set; }
    }
}
