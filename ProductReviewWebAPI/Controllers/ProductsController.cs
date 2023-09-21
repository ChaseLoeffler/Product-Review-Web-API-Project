using Microsoft.AspNetCore.Mvc;
using ProductReviewWebAPI.Data;
using ProductReviewWebAPI.DTOs;
using ProductReviewWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductReviewWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Products or api/Products?maxprice=5
        [HttpGet]
        public IActionResult GetAllProducts([FromQuery] double? maxprice)
        {

            if (maxprice != null)
            {
                var pricedProducts = _context.Products.Select(p => new ProductDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Reviews = p.Reviews.Select(r => new ReviewDTO
                    {
                        Id = r.Id,
                        Text = r.Text,
                        Rating = r.Rating

                    }).ToList(),
                    AverageRating = Math.Round(p.Reviews.Select(r => r.Rating).ToArray().Average(), 1)
                }).Where(p => p.Price <= maxprice).ToList();
                return Ok(pricedProducts);

            }
            var products = _context.Products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Reviews = p.Reviews.Select(r => new ReviewDTO
                {
                    Id = r.Id,
                    Text = r.Text,
                    Rating = r.Rating

                }).ToList(),
                AverageRating = Math.Round(p.Reviews.Select(r => r.Rating).ToArray().Average(), 1)
            }).ToList();
            return Ok(products);
        }

        // GET api/Products/5
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _context.Products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Reviews = p.Reviews.Select(r => new ReviewDTO
                {
                    Id = r.Id,
                    Text = r.Text,
                    Rating = r.Rating

                }).ToList(),
                AverageRating = Math.Round(p.Reviews.Select(r => r.Rating).ToArray().Average(), 1)
            }).Where(p => p.Id == id).ToList();

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST api/Products
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return StatusCode(201, product);
        }

        // PUT api/Products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
