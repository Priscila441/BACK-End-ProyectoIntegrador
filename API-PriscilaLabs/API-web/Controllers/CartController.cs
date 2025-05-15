using API_web.Context;
using API_web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            //var carts = _context.Carts.ToList();
            var carts = _context.Carts.Include(c => c.CartDetails).ToList();
            return Ok(carts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            //var cart = _context.Carts.Find(id);
            var cart = _context.Carts
                .Include(c => c.CartDetails)
                .ThenInclude(cd => cd.Product) // optional, to include product data
                .FirstOrDefault(c => c.IdCart == id);

            if (cart == null) {
                return NotFound();
            }
            return Ok(cart);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Cart cart)
        {
            _context.Carts.Add(cart);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = cart.IdCart }, cart);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id , [FromBody] Cart cart) {
            var existing = _context.Carts.Find(id);
            if (existing == null) {
                return NotFound();
            }
            existing.Total = cart.Total;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            var cart = _context.Carts.Find(id);
            if (cart == null)
            {
                return NotFound();
            }
            _context.Carts.Remove(cart);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
