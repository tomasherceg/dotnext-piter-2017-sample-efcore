using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using EfCore2Demo.DTO;
using EfCore2Demo.Services;

namespace EfCore2Demo.ViewModels
{
    public class DefaultViewModel : DotvvmViewModelBase
    {
        private readonly ProductService productService;

        public List<ProductDTO> Products { get; private set; } = new List<ProductDTO>();

        public List<ProductOrderCountDTO> ProductOrders { get; private set; } = new List<ProductOrderCountDTO>();


        public DefaultViewModel(ProductService productService)
        {
            this.productService = productService;
        }

        public override Task PreRender()
        {
            if (!Context.IsPostBack)
            {
                LoadProducts();
            }

            return base.PreRender();
        }

        public void LoadProducts()
        {
            Products = productService.GetAllProducts();
        }

        public void LoadOrderCounts()
        {
            ProductOrders = productService.GetOrderCounts();
        }
        public void LoadAllOrderCounts()
        {
            ProductOrders = productService.GetAllOrderCounts();
        }
    }

}
