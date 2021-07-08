using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Models
{
    public class ProductListResponseDTO
    {
        // DTO -> Data Transfer Object: Send whatever the client needs.

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public string ImageUrl { get; set; }
        public double Rating { get; set; }
    }
}
