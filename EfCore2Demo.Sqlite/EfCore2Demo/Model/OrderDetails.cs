using System;
using System.Collections.Generic;

namespace EfCore2Demo.Model
{
    public partial class OrderDetails
    {
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public string UnitPrice { get; set; }
        public long Quantity { get; set; }
        public double Discount { get; set; }

        public Orders Order { get; set; }
        public Products Product { get; set; }
    }
}
