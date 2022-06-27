using Microsoft.AspNetCore.Mvc;
using NorthwindApp.Api.Domain.DTOs;
using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Api.Payloads;
using NorthwindApp.Infrastructure.Api.Entities;
using System.Threading.Tasks;

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

        [HttpGet]
        public async Task<ActionResult> GetAllCategories()
        {
            return Ok(await _categoryService.GetAllCategories());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCategory(int id)
        {
            return Ok(await _categoryService.GetCategoryById(id));
        }

        [HttpPost]
        public async Task<ActionResult> CreateCategory([FromBody] CategoryPayload category)
        {
            await _categoryService.CreateCategory(category);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCategory([FromBody] Category category)
        {
            await _categoryService.UpdateCategory(category);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategory(id);

            return Ok();
        }
    }
}
