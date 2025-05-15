using API_web.Context;
using API_web.Models;
using API_web.Repositories.Interfaces;

namespace API_web.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly AppDbContext _context;

        public CartRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task<Cart> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<Cart> GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Cart> Create(Cart cart)
        {
            throw new NotImplementedException();
        }
        public Task<Cart> Update(int id, Cart cart)
        {
            throw new NotImplementedException();
        }
        public Task<Cart> Delete(int id)
        {
            throw new NotImplementedException();
        }        
    }
}
