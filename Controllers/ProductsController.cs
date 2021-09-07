using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotnet_HERO.Controllers
{
    [ApiController]
    [Route("[controller]")] //https://locahost:5001/products (dev)
    public class ProductsController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetProducts()
        {
            var Products = new List<string>();
            Products.Add("Nokia");
            Products.Add("Oppo");
            return Ok(Products);//Status Success 200
        }

        [HttpGet("{id}")] //https://locahost:5001/products/{id}
        
        public IActionResult GetProductsById(int id)
        {
            var Products = new List
            return null;
        }
    }
}
