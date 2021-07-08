using IntroWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Business
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()  // Fake Db model
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id=2,
                    Name = "JBL",
                    Description="JBL Bluetooth Headphones",
                    Price= 650.25M ,
                    Discount=0.15f,
                    ImageUrl="www.trendyol.com/images/resim1.jpg",
                    IsActive=true,
                    Stock = 1000,
                    CreateTime = DateTime.Now
                },

                new Product
                {
                    Id=3, Name = "Adidas",
                    Description="White T-shirt",
                    Price= 350.25M ,
                    Discount=0.15f,
                    ImageUrl="www.trendyol.com/images/resim1.jpg",
                    IsActive=false,
                    Stock = 200,
                    CreateTime = new DateTime(2021, 1,29)
                },
            };
            products.Add(new Product
            {
                Id = 1,
                Name = "Apple",
                Description = "Apple Airpods 2nd Generation Bluetooth Headphones",
                Price = 1301.26M,
                Discount = 0.15f,
                IsActive = true,
                Stock = 1500,
                CreateTime = new DateTime(2021, 3, 30)
            });

            return products;
        }
       
    }
}
