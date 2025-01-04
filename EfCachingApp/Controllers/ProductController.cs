using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EfCachingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
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
    }
}
