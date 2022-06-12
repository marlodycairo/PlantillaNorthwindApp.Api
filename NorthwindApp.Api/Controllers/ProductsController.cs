using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Infrastructure.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id)
        {
            return await _productService.GetProductById(id);
        }

        [HttpPost]
        public async Task CreateProduct([FromBody] Product product)
        {
            await _productService.CreateProduct(product);
        }

        [HttpPut("{id}")]
        public async Task UpdateProduct([FromBody] Product product)
        {
            await _productService.UpdateProduct(product);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task DeleteProduct(int id)
        {
            await _productService.DeleteProduct(id);
        }
    }
}
