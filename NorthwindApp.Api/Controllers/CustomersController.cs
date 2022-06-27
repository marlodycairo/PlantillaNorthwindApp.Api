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
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            var customers = await _customerService.GetAllCustomers();

            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCustomer(int id)
        {
            return Ok(await _customerService.GetCustomerById(id));
        }

        [HttpPost]
        public async Task<ActionResult> CreateCustomer([FromBody] Customer customer)
        {
            await _customerService.CreateCustomer(customer);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCustomer([FromBody] Customer customer)
        {
            await _customerService.UpdateCustomer(customer);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            await _customerService.DeleteCustomer(id);

            return Ok();
        }
    }
}
