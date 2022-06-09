using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Infrastructure.Api.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //IRepository<User> UserRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
