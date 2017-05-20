using System;
using System.Collections.Generic;

namespace EfCore2Demo.Model
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public long? SupplierId { get; set; }
        public long? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public long? UnitsInStock { get; set; }
        public long? UnitsOnOrder { get; set; }
        public long? ReorderLevel { get; set; }
        public string Discontinued { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Categories Category { get; set; }
        public Suppliers Supplier { get; set; }
    }
}
