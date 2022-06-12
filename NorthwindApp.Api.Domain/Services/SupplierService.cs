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
    public class SupplierService : ISupplierService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SupplierService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateSupplier(Supplier supplier)
        {
            await _unitOfWork.SupplierRepository.Add(supplier);
        }

        public async Task DeleteSupplier(int id)
        {
            await _unitOfWork.SupplierRepository.Delete(id);
        }

        public async Task<IEnumerable<Supplier>> GetAllSuppliers()
        {
            return await _unitOfWork.SupplierRepository.GetAll();
        }

        public async Task<Supplier> GetSupplierById(int id)
        {
            return await _unitOfWork.SupplierRepository.GetById(id);
        }

        public async Task UpdateSupplier(Supplier supplier)
        {
            await _unitOfWork.SupplierRepository.Update(supplier);
        }
    }
}
