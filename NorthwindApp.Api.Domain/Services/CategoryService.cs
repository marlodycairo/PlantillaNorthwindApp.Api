using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Infrastructure.Api.Entities;
using NorthwindApp.Infrastructure.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateCategory(Category category)
        {
            await _unitOfWork.CategoryRepository.Add(category);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            await _unitOfWork.CategoryRepository.Delete(id);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _unitOfWork.CategoryRepository.GetAll();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _unitOfWork.CategoryRepository.GetById(id);
        }

        public async Task UpdateCategory(Category category)
        {
            await _unitOfWork.CategoryRepository.Update(category);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
