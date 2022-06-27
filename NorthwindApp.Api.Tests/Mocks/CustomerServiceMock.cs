using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Infrastructure.Api.Entities;
using NorthwindApp.Infrastructure.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Tests.Mocks
{
    public class CustomerServiceMock : ICustomerService
    {
        public CustomerServiceMock(IUnitOfWork unitOfWork)
        {

        }
        public Task CreateCustomer(Customer customer)
        {
            return Task.FromResult(customer);
        }

        public Task DeleteCustomer(int id)
        {
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Customer>> GetAllCustomers()
        {
            IEnumerable<Customer> customer = new List<Customer>();
            //return (Task<IEnumerable<Customer>>)Task.CompletedTask;
            return Task.FromResult(customer);
        }

        public Task<Customer> GetCustomerById(int id)
        {
            Customer customer = new Customer();
            return Task.FromResult(customer);
        }

        public Task UpdateCustomer(Customer customer)
        {
            return Task.FromResult(customer);
        }
    }
}
