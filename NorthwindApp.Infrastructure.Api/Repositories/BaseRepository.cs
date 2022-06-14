using Microsoft.EntityFrameworkCore;
using NorthwindApp.Infrastructure.Api.Context;
using NorthwindApp.Infrastructure.Api.Entities;
using NorthwindApp.Infrastructure.Api.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindApp.Infrastructure.Api.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly NorthwindContext _context;
        private readonly DbSet<T> _entities;

        public BaseRepository(NorthwindContext context)
        {
            _context = context;

            _entities = _context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task Delete(int id)
        {
            var entityById = await GetById(id);

            _entities.Remove(entityById);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task Update(T entity)
        {
            //var entityById = await GetById(entity.Id);

            _entities.Update(entity);
        }
    }
}
