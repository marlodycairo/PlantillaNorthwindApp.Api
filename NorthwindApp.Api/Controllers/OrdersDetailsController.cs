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
    public class OrdersDetailsController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrdersDetailsController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderDetail>> GetOrderDetails()
        {
            return await _orderDetailService.GetAllOrdersDetails();
        }

        [HttpGet("{id}")]
        public async Task<OrderDetail> GetOrderDetail(int id)
        {
            return await _orderDetailService.GetOrderDetailById(id);
        }

        [HttpPost]
        public async Task CreateOrderDetail([FromBody] OrderDetail orderDetail)
        {
            await _orderDetailService.CreateOrderDetail(orderDetail);
        }

        [HttpPut("{id}")]
        public async Task UpdateOrderDetail([FromBody] OrderDetail orderDetail)
        {
            await _orderDetailService.UpdateOrderDetail(orderDetail);
        }

        [HttpDelete("{id}")]
        public async Task DeleteOrderDetail(int id)
        {
            await _orderDetailService.DeleteOrderDetail(id);
        }
    }
}
