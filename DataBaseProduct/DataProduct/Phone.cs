using System;
using System.Collections.Generic;

namespace Hyperion_Store.DB.DataProduct
{
    public partial class Phone
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public string? Phone1 { get; set; }
        public int? OrderId { get; set; }
        public int? Price { get; set; }

        public virtual Order? Order { get; set; }
    }
}
