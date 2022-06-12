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
    public class TerritoriesController : ControllerBase
    {
        private readonly ITerritoryService _territoryService;

        public TerritoriesController(ITerritoryService territoryService)
        {
            _territoryService = territoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Territory>> GetTerritories()
        {
            return await _territoryService.GetAllTerritories();
        }

        [HttpGet("{id}")]
        public async Task<Territory> GetTerritory(int id)
        {
            return await _territoryService.GetTerritoryById(id);
        }

        [HttpPost]
        public async Task CreateTerritory([FromBody] Territory territory)
        {
            await _territoryService.CreateTerritory(territory);
        }

        [HttpPut("{id}")]
        public async Task UpdateTerritory([FromBody] Territory territory)
        {
            await _territoryService.UpdateTerritory(territory);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task DeleteTerritory(int id)
        {
            await _territoryService.DeleteTerritory(id);
        }
    }
}
