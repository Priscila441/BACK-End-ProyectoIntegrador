using API_web.Context;
using API_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var category = _context.Categories.ToList();
            return Ok(category);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = category.IdCategory }, category);

        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Category category)
        {
            var existing = _context.Categories.Find(id);
            if (existing == null)
            {
                return NotFound();
            }

            existing.NameCategory = category.NameCategory;
            
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id) {
            var category = _context.Categories.Find(id);

            if (category == null) {
                return NotFound();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
