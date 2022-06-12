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
    public class ShippersController : ControllerBase
    {
        private readonly IShipperService _shipperService;

        public ShippersController(IShipperService shipperService)
        {
            _shipperService = shipperService;
        }

        [HttpGet]
        public async Task<IEnumerable<Shipper>> GetShippers()
        {
            return await _shipperService.GetAllShippers();
        }

        [HttpGet("{id}")]
        public async Task<Shipper> GetShipper(int id)
        {
            return await _shipperService.GetShipperById(id);
        }

        [HttpPost]
        public async Task CreateShipper([FromBody] Shipper shipper)
        {
            await _shipperService.CreateShipper(shipper);
        }

        [HttpPut("{id}")]
        public async Task UpdateShipper([FromBody] Shipper shipper)
        {
            await _shipperService.UpdateShipper(shipper);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task DeleteShipper(int id)
        {
            await _shipperService.DeleteShipper(id);
        }
    }
}
