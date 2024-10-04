using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.Repositories;

namespace TechStore.Controllers.v1.Products
{
    [ApiController]
    [Route("api/v1/products")]
    public class ProductsController(IProductRepository productRepository) : ControllerBase
    {
        protected readonly IProductRepository _productRepository = productRepository;
    }
}