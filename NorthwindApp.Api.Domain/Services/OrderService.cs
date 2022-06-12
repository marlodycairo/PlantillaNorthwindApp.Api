using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Infrastructure.Api.Entities;
using NorthwindApp.Infrastructure.Api.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateOrder(Order order)
        {
            await _unitOfWork.OrderRepository.Add(order);
        }

        public async Task DeleteOrder(int id)
        {
            await _unitOfWork.OrderRepository.Delete(id);
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _unitOfWork.OrderRepository.GetAll();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _unitOfWork.OrderRepository.GetById(id);
        }

        public async Task UpdateOrder(Order order)
        {
            await _unitOfWork.OrderRepository.Update(order);
        }
    }
}
