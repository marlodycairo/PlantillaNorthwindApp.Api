using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindApp.Infrastructure.Api.Entities
{
    public partial class Shipper : BaseEntity
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        //public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
