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
    public class RegionService : IRegionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

         public async Task CreateRegion(Region region)
        {
            await _unitOfWork.RegionRepository.Add(region);
        }

        public async Task DeleteRegion(int id)
        {
            await _unitOfWork.RegionRepository.Delete(id);
        }

        public async Task<IEnumerable<Region>> GetAllRegions()
        {
            return await _unitOfWork.RegionRepository.GetAll();
        }

        public async Task<Region> GetRegionById(int id)
        {
            return await _unitOfWork.RegionRepository.GetById(id);
        }

        public async Task UpdateRegion(Region region)
        {
            await _unitOfWork.RegionRepository.Update(region);
        }
    }
}
