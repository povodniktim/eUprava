using Microsoft.EntityFrameworkCore;

namespace eUprava.Data
{
    public class eUpravaContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "eUprava.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
