using Microsoft.AspNetCore.Mvc;
using NorthwindApp.Api.Domain.DTOs;
using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Api.Payloads;
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
        public async Task<ActionResult> GetAllCategories()
        {
            return Ok(await _categoryService.GetAllCategories());
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCategory(int id)
        {
            return Ok(await _categoryService.GetCategoryById(id));
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public async Task<ActionResult> CreateCategory([FromBody] CategoryPayload category)
        {
            await _categoryService.CreateCategory(category);

            return Ok();
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCategory([FromBody] CategoryDto category)
        {
            await _categoryService.UpdateCategory(category);

            return Ok();
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategory(id);

            return Ok();
        }
    }
}
