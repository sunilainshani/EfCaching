using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using EfCachingApp.DataAccess;
using EfCachingApp.DataAccess.Entities;

namespace EfCachingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public string Get()
        {
            return "Hello Sunil!";
        }

        [HttpGet]
        [Route("GetProductData")]
        public string GetProductData()
        {
            return "This is inside GetPrdocutData";
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            Console.WriteLine("Entering GetAllProducts ..........");

            var productList = _dbContext.Product;

            foreach(Product product in productList )
            {
                Console.WriteLine("Product Id > " + product.ProductId);
                Console.WriteLine("Product Name > " + product.ProductName);

            }

            return Ok(productList);
        }
    }
}
