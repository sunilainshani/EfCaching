using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public string Get()
        {
            return "Hi Sunil!";
        }

        [HttpGet("{ProductId}")]
        public string GetProductData(int ProductId)
        {
            return "Hi Sunil - product id is >>  " + ProductId;
        }

    }
}
