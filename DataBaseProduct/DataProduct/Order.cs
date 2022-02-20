using System;
using System.Collections.Generic;

namespace Hyperion_Store.DB.DataProduct
{
    public partial class Order
    {
        public Order()
        {
            Computers = new HashSet<Computer>();
            Laptops = new HashSet<Laptop>();
            Monitors = new HashSet<Monitor>();
            Phones = new HashSet<Phone>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? OrderedProduct { get; set; }
        public int? CustomerId { get; set; }
        public int? SerialNumber { get; set; }
        public int? Amount { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }
        public virtual ICollection<Laptop> Laptops { get; set; }
        public virtual ICollection<Monitor> Monitors { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
}
