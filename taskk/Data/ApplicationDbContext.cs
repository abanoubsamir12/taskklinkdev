using Microsoft.EntityFrameworkCore;
using taskk.Models;

namespace taskk.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Class> classes { get; set; }
        public DbSet<TV> tvs { get; set; }
        public DbSet<Laptop> laptops { get; set; }
        public DbSet<UserInfo> users { get; set; }
        public DbSet<SoundSystem> ssystems { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}
