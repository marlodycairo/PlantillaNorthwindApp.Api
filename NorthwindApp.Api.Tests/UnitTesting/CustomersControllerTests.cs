using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NorthwindApp.Api.Controllers;
using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Api.Domain.Services;
using NorthwindApp.Api.Tests.Mocks;
using NorthwindApp.Infrastructure.Api.Entities;
using NorthwindApp.Infrastructure.Api.Repositories;
using NorthwindApp.Infrastructure.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Tests.UnitTesting
{
    [TestClass]
    public class CustomersControllerTests : BasePruebas
    {
        [TestMethod]
        public async Task GetAllCustomers()
        {
            //Preparacion
            var nombreDB = Guid.NewGuid().ToString();

            var context = ConstruirContext(nombreDB);

            var unitOfWork = new UnitOfWork(context);

            //var newCustomer = context.Customers.Add(new Customer()
            await unitOfWork.CustomerRepository.Add(new Customer()
            {
                Id = 1,
                CompanyName = "Reposteria Manantial",
                ContactName = "Juan Luis Duarte",
                ContactTitle = "Owner",
                Address = "Av las vegas #76-32sur",
                City = "Sabaneta",
                Region = "Antioquia",
                PostalCode = "505052",
                Country = "Colombia",
                Phone = "3228792343",
                Fax = "576044352422"
            });

            await unitOfWork.CustomerRepository.Add(new Customer()
            {
                Id = 2,
                CompanyName = "Carnicos El mamut",
                ContactName = "Pedro Martinelly",
                ContactTitle = "Sales Representative",
                Address = "Transversal 2 #32-24",
                City = "Medellin",
                Region = "Antioquia",
                PostalCode = "505051",
                Country = "Colombia",
                Phone = "3298379388",
                Fax = "576043334432"
            });

            await context.SaveChangesAsync();

            var context2 = ConstruirContext(nombreDB);

            //Prueba

            //unitOfWork = new UnitOfWork(context2);

            var customerService = new CustomerService(unitOfWork);

            var controller = new CustomersController(customerService);
            var respuestaService = await customerService.GetAllCustomers();
            
            var respuestaController = await controller.GetCustomers();

            //Verificación
            var customers = respuestaService.ToList();

            var lstCustomers = respuestaController.Result as OkObjectResult;

            var resultLstCustomers = lstCustomers.Value as List<Customer>;

            Assert.AreEqual(2, customers.Count);
            Assert.AreEqual(2, resultLstCustomers.Count);
        }
    }
}
