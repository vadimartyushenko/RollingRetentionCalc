using DBRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DBRepository
{
    public class RepositoryContextFactory : IRepositoryContextFactory
    {
        public RepositoryContext CreateDbContext(string connectionString)
        {
            var optionBuilder = new DbContextOptionsBuilder<RepositoryContext>();
            optionBuilder.UseNpgsql(connectionString);

            return new RepositoryContext(optionBuilder.Options);
        }
    }
}
