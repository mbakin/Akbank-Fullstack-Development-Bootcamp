using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }

        // More features - Details that the user does not need to know 
        public List<string> Properties { get; set; }
        public List<string> Colors { get; set; }

        public int Stock { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdatedTime { get; set; }

        public bool IsActive { get; set; }
    }
}
