using Microsoft.EntityFrameworkCore;

namespace App6
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=s.anosov.ru;user=OrlovA;password=pEEwT@7#;database=OrlovA;"
            );
        }
    }
}
