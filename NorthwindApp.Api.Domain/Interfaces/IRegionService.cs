using NorthwindApp.Infrastructure.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Domain.Interfaces
{
    public interface IRegionService
    {
        Task<IEnumerable<Region>> GetAllRegions();
        Task<Region> GetRegionById(int id);
        Task CreateRegion(Region region);
        Task UpdateRegion(Region region);
        Task DeleteRegion(int id);
    }
}
