using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Repositories;

namespace TechStore.Controllers.v1.Products;
[ApiController]
[Route("api/[controller]")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("products")]
public class ProductsDeleteController(IProductRepository productRepository) : ProductsController(productRepository)
{
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id){
        var product = await _productRepository.CheckExistence(id);
        if (product == false){
            return NotFound();
        }
        await _productRepository.Delete(id);
        return NoContent();
    }

}
