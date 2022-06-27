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
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
 
        [HttpGet]
        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await _orderService.GetAllOrders();
        }

        [HttpGet("{id}")]
        public async Task<Order> GetOrder(int id)
        {
            return await _orderService.GetOrderById(id);
        }

        [HttpPost]
        public async Task CreateOrder([FromBody] Order order)
        {
            await _orderService.CreateOrder(order);
        }

        [HttpPut("{id}")]
        public async Task UpdateOrder([FromBody] Order order)
        {
            await _orderService.UpdateOrder(order);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task DeleteOrder(int id)
        {
            await _orderService.DeleteOrder(id);
        }
    }
}
