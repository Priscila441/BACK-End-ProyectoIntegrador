using API_web.Context;
using API_web.Repositories.Interfaces;

namespace API_web.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public ICartRepository Carts { get; private set; }
        public ICartDetailRepository CartsDetails { get; private set; }
        public ICategoryRepository Categories { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IProductRepository Products { get; private set; }
        public IUserRepository Users { get; private set; }
        public UnitOfWork(AppDbContext context,
                          ICartRepository cart ,
                          ICartDetailRepository cartDetail,
                          ICategoryRepository category,
                          IOrderRepository order, 
                          IProductRepository product, 
                          IUserRepository user) {
            _context = context;
            Carts = cart;
            CartsDetails = cartDetail;
            Categories = category;
            Orders = order;
            Products = product;
            Users = user;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
