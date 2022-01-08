
namespace DBRepository.Interfaces
{
    interface IRepositoryContextFactory
    {
        public RepositoryContext CreateDbContext(string connectionString);
    }
}
