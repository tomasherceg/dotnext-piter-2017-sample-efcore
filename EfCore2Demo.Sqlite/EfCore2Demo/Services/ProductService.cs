using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCore2Demo.DTO;
using EfCore2Demo.Model;
using Microsoft.EntityFrameworkCore;

namespace EfCore2Demo.Services
{
    public class ProductService
    {
        private readonly NorthwindContext context;

        public ProductService(NorthwindContext context)
        {
            this.context = context;
        }

        public List<ProductDTO> GetAllProducts()
        {
            return context.Products.Select(p => new ProductDTO()
            {
                Id = p.ProductId,
                Name = p.ProductName,
                SupplierName = p.Supplier.CompanyName,
                CategoryName = p.Category.CategoryName
            })
            .OrderBy(p => p.Id)
            .ToList();
        }

        public List<ProductOrderCountDTO> GetOrderCounts()
        {
            return context.Products
                .Select(p => new ProductOrderCountDTO()
                {
                    Id = p.ProductId,
                    Name = p.ProductName,
                    OrdersCount = p.OrderDetails.Sum(d => d.Quantity)
                })
                .OrderBy(p => p.Id)
                .ToList();
        }

        public List<ProductOrderCountDTO> GetAllOrderCounts()
        {
            return context.Products
                .IgnoreQueryFilters()
                .Select(p => new ProductOrderCountDTO()
                {
                    Id = p.ProductId,
                    Name = p.ProductName,
                    OrdersCount = p.OrderDetails.Sum(d => d.Quantity)
                })
                .OrderBy(p => p.Id)
                .ToList();
        }
    }
}
