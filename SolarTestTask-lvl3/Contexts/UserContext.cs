using Microsoft.EntityFrameworkCore;
using SolarTestTask_lvl3.Models;

namespace SolarTestTask_lvl3.Contexts
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public UserContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Data Source=SolarTestMVC.db");
        }
    }
}
