using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStore.Models;

namespace TechStore.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product?> GetById(int id);
        Task<IEnumerable<Product>> GetByKeyword(string keyword);
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(int id);
        Task<bool> CheckExistence(int id);
    }
}