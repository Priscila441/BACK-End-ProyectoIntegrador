using API_web.Context;
using API_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderController (AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var order = _context.Orders.ToList();
            return Ok(order);

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null) {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Order order) {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = order.IdOrder }, order);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Order order) {
            var existing = _context.Orders.Find(id);
            if (existing == null) {
                return NotFound();
            }
            existing.StateOrder = order.StateOrder;
            existing.PaymentMethod = order.PaymentMethod;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
