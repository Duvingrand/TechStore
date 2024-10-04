using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Data;
using TechStore.Models;
using TechStore.Repositories;

namespace TechStore.Services;

public class ProductServices : IProductRepository
{
    private readonly ApplicationDbContext _context;
    public ProductServices(ApplicationDbContext context){
        _context = context;
    }
    public Task Add(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CheckExistence(int id)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Product?> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetByKeyword(string keyword)
    {
        throw new NotImplementedException();
    }

    public Task Update(Product product)
    {
        throw new NotImplementedException();
    }
}
