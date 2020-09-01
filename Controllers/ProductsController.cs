using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_FromScratch.Models;

namespace WebAPI_FromScratch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> products = new List<Product>()
        {
            new Product
            {
                Id= 1006368,
                Name= "Austin and Barbeque AABQ Wifi Food Thermometer",
                Description= "Thermometer with Wifi",
                Price= 399
            },
            new Product
            {
                Id= 1009334,
                Name= "Andersson",
                Description= "Electric",
                Price= 89
            },
            new Product
            {
                Id= 1002266,
                Name= "Weber Non-Stick",
                Description= "BBQ",
                Price= 99
            }
        };
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var product = products.Find(product => product.Id == id);
            return product;
        }
    }
}
