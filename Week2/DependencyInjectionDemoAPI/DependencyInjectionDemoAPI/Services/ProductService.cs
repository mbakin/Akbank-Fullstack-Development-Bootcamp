using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemoAPI.Data;
using DependencyInjectionDemoAPI.Models;

namespace DependencyInjectionDemoAPI.Services
{
    public class ProductService : IProductService
    {
        private MiniDbContext miniDbContext;

        public ProductService(MiniDbContext miniDbContext)
        {
            this.miniDbContext = miniDbContext;
        }
        public IList<Product> GetProducts()
        {
            return miniDbContext.Products.ToList();
        }
    }
}
