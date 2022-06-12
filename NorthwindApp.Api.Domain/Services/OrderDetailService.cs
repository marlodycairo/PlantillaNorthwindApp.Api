using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Infrastructure.Api.Entities;
using NorthwindApp.Infrastructure.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Domain.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateOrderDetail(OrderDetail orderDetail)
        {
            await _unitOfWork.OrderDetailRepository.Add(orderDetail);
        }

        public async Task DeleteOrderDetail(int id)
        {
            await _unitOfWork.OrderDetailRepository.Delete(id);
        }

        public async Task<IEnumerable<OrderDetail>> GetAllOrdersDetails()
        {
            return await _unitOfWork.OrderDetailRepository.GetAll();
        }

        public async Task<OrderDetail> GetOrderDetailById(int id)
        {
            return await _unitOfWork.OrderDetailRepository.GetById(id);
        }

        public async Task UpdateOrderDetail(OrderDetail orderDetail)
        {
            await _unitOfWork.OrderDetailRepository.Update(orderDetail);
        }
    }
}
