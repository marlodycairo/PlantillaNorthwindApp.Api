using NorthwindApp.Infrastructure.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Infrastructure.Api.Repositories.Interfaces 
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Category> CategoryRepository { get; }
        IRepository<Customer> CustomerRepository { get; }
        IRepository<Employee> EmployeeRepository { get; }
        IRepository<Order> OrderRepository { get; }
        IRepository<OrderDetail> OrderDetailRepository { get; }
        IRepository<Product> ProductRepository { get; }
        IRepository<Region> RegionRepository { get; }
        IRepository<Shipper> ShipperRepository { get; }
        IRepository<Supplier> SupplierRepository { get; }
        IRepository<Territory> TerritoryRepository { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
