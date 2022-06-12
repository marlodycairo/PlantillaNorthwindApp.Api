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
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet]
        public async Task<IEnumerable<Supplier>> GetSuppliers()
        {
            return await _supplierService.GetAllSuppliers();
        }

        [HttpGet("{id}")]
        public async Task<Supplier> GetSupplier(int id)
        {
            return await _supplierService.GetSupplierById(id);
        }

        [HttpPost]
        public async Task CreateSupplier([FromBody] Supplier supplier)
        {
            await _supplierService.CreateSupplier(supplier);
        }

        [HttpPut("{id}")]
        public async Task UpdateSupplier([FromBody] Supplier supplier)
        {
            await _supplierService.UpdateSupplier(supplier);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task DeleteSupplier(int id)
        {
            await _supplierService.DeleteSupplier(id);
        }
    }
}
