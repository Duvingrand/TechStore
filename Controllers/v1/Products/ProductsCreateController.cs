using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Models;
using TechStore.Repositories;

namespace TechStore.Controllers.v1.Products
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("products")]
    public class ProductsCreateController(IProductRepository productRepository) : ProductsController(productRepository)
    {
        [HttpPost]
        public async Task<ActionResult<Product>> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var newProduct = new Product(product.Name, product.Price, product.Description, product.CategoryId);
            await _productRepository.Add(newProduct);
            return Ok(newProduct);
        }

    }
}