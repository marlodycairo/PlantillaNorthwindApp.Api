using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindApp.Infrastructure.Api.Entities
{
    public partial class OrderView
    {
        public int OrderId { get; set; }
        public int? EmployeeId { get; set; }
    }
}
