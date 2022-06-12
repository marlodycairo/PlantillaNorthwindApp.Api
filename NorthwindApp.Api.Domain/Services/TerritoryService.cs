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
    public class TerritoryService : ITerritoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TerritoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateTerritory(Territory territory)
        {
            await _unitOfWork.TerritoryRepository.Add(territory);
        }

        public async Task DeleteTerritory(int id)
        {
            await _unitOfWork.TerritoryRepository.Delete(id);
        }

        public async Task<IEnumerable<Territory>> GetAllTerritories()
        {
            return await _unitOfWork.TerritoryRepository.GetAll();
        }

        public async Task<Territory> GetTerritoryById(int id)
        {
            return await _unitOfWork.TerritoryRepository.GetById(id);
        }

        public async Task UpdateTerritory(Territory territory)
        {
            await _unitOfWork.TerritoryRepository.Update(territory);
        }
    }
}
