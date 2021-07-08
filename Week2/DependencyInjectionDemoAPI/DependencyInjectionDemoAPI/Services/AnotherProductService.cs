using DependencyInjectionDemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemoAPI.Services
{
    public class AnotherProductService : IProductService
    {
        public IList<Product> GetProducts()
        {
            return new List<Product> {new Product {Id = 982, Name = "Other product", Price = 500} };
        }
    }
}
