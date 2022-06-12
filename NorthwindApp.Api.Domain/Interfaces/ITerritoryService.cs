using NorthwindApp.Infrastructure.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Domain.Interfaces
{
    public interface ITerritoryService
    {
        Task<IEnumerable<Territory>> GetAllTerritories();
        Task<Territory> GetTerritoryById(int id);
        Task CreateTerritory(Territory territory);
        Task UpdateTerritory(Territory territory);
        Task DeleteTerritory(int id);
    }
}
