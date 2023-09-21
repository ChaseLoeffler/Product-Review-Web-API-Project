using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductReviewWebAPI.Data;
using ProductReviewWebAPI.DTOs;
using ProductReviewWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductReviewWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Reviews
        [HttpGet]
        public IActionResult GetAllReviews()
        {
            var reviews = _context.Reviews.ToList();
            return Ok(reviews);
        }

        // GET api/Reviews/5
        [HttpGet("{id}")]
        public IActionResult GetReviewById(int id)
        {
            var review = _context.Reviews.Find(id);
            if (review == null)
            {
                return NotFound();
            }
            return Ok(review);
        }

        // GET api/Reviews/ByProduct/1
        [HttpGet("ByProduct/{id}")]
        public IActionResult GetReviewByProductId(int id)
        {
            var review = _context.Reviews.Where(r=>r.ProductId==id).ToList();
            if (review == null)
            {
                return NotFound();
            }
            return Ok(review);
        }

        // POST api/Reviews
        [HttpPost]
        public IActionResult CreateReview([FromBody] Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
            return StatusCode(201, review);
        }

        // PUT api/Reviews/5
        [HttpPut("{id}")]
        public IActionResult UpdateReview(int id, [FromBody] Review review)
        {
            var upReview = _context.Reviews.FirstOrDefault(r => r.Id == id);
            if(upReview == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                upReview.Text = review.Text;
                upReview.Rating = review.Rating;
                upReview.ProductId = review.ProductId;

                _context.SaveChanges();

                return StatusCode(200, upReview);
            }
            return BadRequest(ModelState);
        }

        // DELETE api/Reviews/5
        [HttpDelete("{id}")]
        public IActionResult DeleteReview(int id)
        {
            var review = _context.Reviews.Find(id);
            if (review == null)
            {
                return NotFound();
            }
            _context.Reviews.Remove(review);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
