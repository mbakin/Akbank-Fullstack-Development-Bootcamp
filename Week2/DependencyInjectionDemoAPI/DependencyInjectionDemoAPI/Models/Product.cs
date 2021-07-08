using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionDemoAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? StockCount { get; set; }
        public DateTime? CreateTime { get; set; }
        public float? Discount { get; set; }
        public string ImageUrl { get; set; }
    }
}
