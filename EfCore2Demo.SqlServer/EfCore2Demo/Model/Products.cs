﻿using System;
using System.Collections.Generic;

namespace EfCore2Demo.Model
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Categories Category { get; set; }
        public Suppliers Supplier { get; set; }
    }
}
