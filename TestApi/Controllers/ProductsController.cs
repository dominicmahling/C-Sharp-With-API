using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Laptop" },
            new Product { Id = 2, Name = "Mouse" }
        };
    }
}