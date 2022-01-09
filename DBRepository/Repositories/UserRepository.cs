
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DBRepository.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }

        public async Task<IEnumerable<User>> GetUsersByDate(DateTime registrationDate)
        {
            //var result = new List<User>();
            await using var context = ContextFactory.CreateDbContext(ConnectionString);
            var query = context.Users.AsQueryable();
            query = query.Where(x => x.RegistrationDate <= registrationDate);
            var result = await query.ToListAsync();

            return result;
        }
    }
}
