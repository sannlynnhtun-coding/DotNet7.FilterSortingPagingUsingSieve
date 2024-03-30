using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sieve.Models;
using Sieve.Services;
using System.Reflection;
using DotNet7.FilterSortingPagingUsingSieve.Db;

namespace DotNet7.FilterSortingPagingUsingSieve.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext db;
        private readonly SieveProcessor sieveProcessor;

        public ProductController(AppDbContext _db, SieveProcessor _sieveProcessor)
        {
            db= _db;
            sieveProcessor= _sieveProcessor;
        }

        [Route("GetProducts")]
        [HttpGet]
        public IActionResult GetProducts([FromQuery] SieveModel model)
        {
            var products = db.Products.AsQueryable();
            products = sieveProcessor.Apply(model, products);
            return Ok(products);
        }
    }
}
