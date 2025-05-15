using API_web.Models;

namespace API_web.Repositories.Interfaces
{
    public interface ICartRepository
    {
        Task<List<Cart>> GetAll();
        Task<Cart> GetById(int id);
        Task<Cart> Create(Cart cart);
        Task<Cart> Update(int id, Cart cart);
        Task<Cart> Delete(int id);
    }
}
