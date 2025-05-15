using API_web.Context;
using API_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var users = _context.Users.Find(id);
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }


        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = user.IdUser }, user);

        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] User user)
        {
            var existing = _context.Users.Find(id);
            if (existing == null)
            {
                return NotFound();
            }

            existing.Name = user.Name;
            existing.Email = user.Email;
            existing.Age = user.Age;
            existing.Password = user.Password;
            existing.Direction = user.Direction;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
