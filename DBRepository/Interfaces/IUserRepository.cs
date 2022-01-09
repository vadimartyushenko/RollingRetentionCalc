
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace DBRepository.Interfaces
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetUsersByDate(DateTime registrationDate);

    }
}
