using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroWebAPI.Models;
using System.Net;
using IntroWebAPI.Business;

namespace IntroWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // Request here
        // GET - POST
        [HttpGet]  // -> Attribute
        public IActionResult Get()
        {
            ProductService dataService = new ProductService();
            var list = dataService.GetListResponseDTOs();
            return Ok(list);
        }
        [HttpGet("{id}")] // -> Attribute
        public IActionResult GetProductById(int id)
        {                                                               // Put Breakpoint and watch
            ProductService dataService = new ProductService();
            var product = dataService.GetProductResponseDto(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        
        [HttpPost]  // -> Attribute
        public IActionResult AddProduct(Product product)
        {
            // Let's consider adding to Database
            return CreatedAtAction(nameof(GetProductById),new {id=3},null);
        }
        [HttpPut]
        public IActionResult Put(int id, Product product)
        {
            // Let's consider adding to Update!
            return Ok();
        }
    }
}
