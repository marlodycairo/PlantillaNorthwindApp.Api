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
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateEmployee(Employee employee)
        {
            await _unitOfWork.EmployeeRepository.Add(employee);
        }

        public async Task DeleteEmployee(int id)
        {
            await _unitOfWork.EmployeeRepository.Delete(id);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _unitOfWork.EmployeeRepository.GetAll();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _unitOfWork.EmployeeRepository.GetById(id);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            await _unitOfWork.EmployeeRepository.Update(employee);
        }
    }
}
