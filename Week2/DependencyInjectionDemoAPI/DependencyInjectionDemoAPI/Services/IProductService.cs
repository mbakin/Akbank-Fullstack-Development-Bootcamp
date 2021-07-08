using DependencyInjectionDemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemoAPI.Services
{
    public interface IProductService
    {
        IList<Product> GetProducts();
    }
}
