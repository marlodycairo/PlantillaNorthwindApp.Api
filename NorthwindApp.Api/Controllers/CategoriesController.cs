using Microsoft.AspNetCore.Mvc;
using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Infrastructure.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NorthwindApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _categoryService.GetAllCategories();
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public async Task<Category> GetCategory(int id)
        {
            return await _categoryService.GetCategoryById(id);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public async Task CreateCategory([FromBody] Category category)
        {
            await _categoryService.CreateCategory(category);
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public async Task UpdateCategory([FromBody] Category category)
        {
            await _categoryService.UpdateCategory(category);
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public async Task DeleteCategory(int id)
        {
            await _categoryService.DeleteCategory(id);
        }
    }
}
