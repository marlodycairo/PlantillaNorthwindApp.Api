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
    public class ShipperService : IShipperService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShipperService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateShipper(Shipper shipper)
        {
            await _unitOfWork.ShipperRepository.Add(shipper);
        }

        public async Task DeleteShipper(int id)
        {
            await _unitOfWork.ShipperRepository.Delete(id);
        }

        public async Task<IEnumerable<Shipper>> GetAllShippers()
        {
            return await _unitOfWork.ShipperRepository.GetAll();
        }

        public async Task<Shipper> GetShipperById(int id)
        {
            return await _unitOfWork.ShipperRepository.GetById(id);
        }

        public async Task UpdateShipper(Shipper shipper)
        {
            await _unitOfWork.ShipperRepository.Update(shipper);
        }
    }
}
