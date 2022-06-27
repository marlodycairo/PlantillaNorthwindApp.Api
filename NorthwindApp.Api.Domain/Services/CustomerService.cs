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
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateCustomer(Customer customer)
        {
            await _unitOfWork.CustomerRepository.Add(customer);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteCustomer(int id)
        {
            await _unitOfWork.CustomerRepository.Delete(id);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _unitOfWork.CustomerRepository.GetAll();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _unitOfWork.CustomerRepository.GetById(id);
        }

        public async Task UpdateCustomer(Customer customer)
        {
            await _unitOfWork.CustomerRepository.Update(customer);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
