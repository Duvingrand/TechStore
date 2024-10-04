using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Data;
using TechStore.Models;
using TechStore.Repositories;

namespace TechStore.Services;

public class UserServices : IUserRepository
{
    private readonly ApplicationDbContext _context;
    public UserServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public Task<User?> GetById(int id)
    {
        throw new NotImplementedException();
    }
}
