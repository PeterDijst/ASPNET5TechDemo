using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace ASPNET5TechDemo.Model
{
    public class RegistrationDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSqlServer(Startup.Configuration.Get("Data:DefaultConnection:ConnectionString"));
        }
    }
}