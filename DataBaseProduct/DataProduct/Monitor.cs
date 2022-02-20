using System;
using System.Collections.Generic;

namespace Hyperion_Store.DB.DataProduct
{
    public partial class Monitor
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public string? Monitor1 { get; set; }
        public int? OrderId { get; set; }
        public int? Price { get; set; }

        public virtual Order? Order { get; set; }
    }
}
