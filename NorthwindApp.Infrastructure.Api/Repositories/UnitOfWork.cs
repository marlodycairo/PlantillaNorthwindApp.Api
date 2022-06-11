using NorthwindApp.Infrastructure.Api.Context;
using NorthwindApp.Infrastructure.Api.Entities;
using NorthwindApp.Infrastructure.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Infrastructure.Api.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NorthwindContext _context;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Customer> _customerRepository;
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<OrderDetail> _orderDetailRepository;
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Region> _regionRepository;
        private readonly IRepository<Shipper> _shipperRepository;
        private readonly IRepository<Supplier> _supplierRepository;
        private readonly IRepository<Territory> _territoryRepository;

        public UnitOfWork(NorthwindContext context)
        {
            _context = context;
        }

        public IRepository<Category> CategoryRepository => _categoryRepository ?? new BaseRepository<Category>(_context);
        public IRepository<Customer> CustomerRepository => _customerRepository ?? new BaseRepository<Customer>(_context);
        public IRepository<Employee> EmployeeRepository => _employeeRepository ?? new BaseRepository<Employee>(_context);
        public IRepository<Order> OrderRepository => _orderRepository ?? new BaseRepository<Order>(_context);
        public IRepository<OrderDetail> OrderDetailRepository => _orderDetailRepository ?? new BaseRepository<OrderDetail>(_context);
        public IRepository<Product> ProductRepository => _productRepository ?? new BaseRepository<Product>(_context);
        public IRepository<Region> RegionRepository => _regionRepository ?? new BaseRepository<Region>(_context);
        public IRepository<Shipper> ShipperRepository => _shipperRepository ?? new BaseRepository<Shipper>(_context);
        public IRepository<Supplier> SupplierRepository => _supplierRepository ?? new BaseRepository<Supplier>(_context);
        public IRepository<Territory> TerritoryRepository => _territoryRepository ?? new BaseRepository<Territory>(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
