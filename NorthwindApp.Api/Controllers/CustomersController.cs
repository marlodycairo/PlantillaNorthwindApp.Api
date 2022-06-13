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
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<ActionResult> GetCustomers()
        {
            return Ok(await _customerService.GetAllCustomers());
        }

        [HttpGet("{id}")]
        public async Task<Customer> GetCustomer(int id)
        {
            return await _customerService.GetCustomerById(id);
        }

        [HttpPost]
        public async Task CreateCustomer([FromBody] Customer customer)
        {
            await _customerService.CreateCustomer(customer);
        }

        [HttpPut("{id}")]
        public async Task UpdateCustomer([FromBody] Customer customer)
        {
            await _customerService.UpdateCustomer(customer);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task DeleteCustomer(int id)
        {
            await _customerService.DeleteCustomer(id);
        }
    }
}
