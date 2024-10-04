using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Models;

namespace TechStore.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetById(int id);
    }
}