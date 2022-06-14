using NorthwindApp.Api.Domain.DTOs;
using NorthwindApp.Api.Payloads;
using NorthwindApp.Infrastructure.Api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Domain.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategories();
        Task<CategoryDto> GetCategoryById(int id);
        Task CreateCategory(CategoryPayload category);
        Task UpdateCategory(CategoryDto category);
        Task DeleteCategory(int id);
    }
}
