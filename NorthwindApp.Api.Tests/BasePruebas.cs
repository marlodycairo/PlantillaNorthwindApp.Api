using Microsoft.EntityFrameworkCore;
using NorthwindApp.Infrastructure.Api.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Api.Tests
{
    public class BasePruebas
    {
        protected NorthwindContext ConstruirContext(string nombreDb)
        {
            var opciones = new DbContextOptionsBuilder<NorthwindContext>()
                    .UseInMemoryDatabase(nombreDb).Options;

            var dbContext = new NorthwindContext(opciones);

            return dbContext;
        }
    }
}
