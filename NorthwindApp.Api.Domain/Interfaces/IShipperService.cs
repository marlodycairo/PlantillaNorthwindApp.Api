using NorthwindApp.Infrastructure.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Domain.Interfaces
{
    public interface IShipperService
    {
        Task<IEnumerable<Shipper>> GetAllShippers();
        Task<Shipper> GetShipperById(int id);
        Task CreateShipper(Shipper shipper);
        Task UpdateShipper(Shipper shipper);
        Task DeleteShipper(int id);
    }
}
