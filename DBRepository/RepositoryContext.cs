
using Microsoft.EntityFrameworkCore;
using Models;

namespace DBRepository
{
	public class RepositoryContext : DbContext
	{
        public RepositoryContext()
        {
            Database.EnsureCreated();
        }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=qq");
        }
        public DbSet<User> Users { get; set; }
    }
}
