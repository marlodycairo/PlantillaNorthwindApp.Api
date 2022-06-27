using AutoMapper;
using NorthwindApp.Api.Domain.DTOs;
using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Api.Payloads;
using NorthwindApp.Infrastructure.Api.Entities;
using NorthwindApp.Infrastructure.Api.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;

            _mapper = mapper;
        }

        public async Task CreateCategory(CategoryPayload category)
        {
            var obCategory = _mapper.Map<Category>(category);

            await _unitOfWork.CategoryRepository.Add(obCategory);

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

            //var lst = _mapper.Map<IEnumerable<CategoryDto>>(lstCategories);

            //return lst.ToList();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _unitOfWork.CategoryRepository.GetById(id);

            //var category = _mapper.Map<CategoryDto>(obCategory);

            //return category;
        }

        public async Task UpdateCategory(Category category)
        {
            //var obCategory = _mapper.Map<Category>(category);

            await _unitOfWork.CategoryRepository.Update(category);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
