using hydra_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace hydra_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet(Name = "GetProduct")]
    public Product Get()
    {
        return new Product
        {
            Name = "Product 1",
            Price = 100
        };
    }
}
