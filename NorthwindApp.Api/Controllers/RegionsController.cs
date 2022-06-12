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
    public class RegionsController : ControllerBase
    {
        private readonly IRegionService _regionService;

        public RegionsController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpGet]
        public async Task<IEnumerable<Region>> GetRegions()
        {
            return await _regionService.GetAllRegions();
        }

        [HttpGet("{id}")]
        public async Task<Region> GetRegion(int id)
        {
            return await _regionService.GetRegionById(id);
        }

        [HttpPost]
        public async Task CreateRegion([FromBody] Region region)
        {
            await _regionService.CreateRegion(region);
        }

        [HttpPut("{id}")]
        public async Task UpdateRegion([FromBody] Region region)
        {
            await _regionService.UpdateRegion(region);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task DeleteRegion(int id)
        {
            await _regionService.DeleteRegion(id);
        }
    }
}
