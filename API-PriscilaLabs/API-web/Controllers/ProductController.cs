using API_web.Context;
using API_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context) {
            _context = context;
        }



        [HttpGet]
        public IActionResult GetAll() {
            var products = _context.Products.ToList();
            return Ok(products);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) {
                return NotFound();
            }
            return Ok(product);
        }


        [HttpPost]
        public IActionResult Create([FromBody] Product product) {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = product.IdProduct }, product);

        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product product) {
            var existing = _context.Products.Find(id);
            if (existing == null) {
                return NotFound();
            }

            existing.NameProduct = product.NameProduct;
            existing.Price = product.Price;
            existing.Title = product.Title;
            existing.Description = product.Description;
            existing.Brand = product.Brand;
            existing.Stock = product.Stock;
            existing.StateProduct = product.StateProduct;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var product = _context.Products.Find(id);
            if (product == null) {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }




    }
}
