namespace API_web.Repositories.Interfaces
{
    public interface IUnitOfWork 
    {
        ICartRepository Carts { get; }
        ICartDetailRepository CartsDetails { get; }
        ICategoryRepository Categories { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        IUserRepository Users { get; }
        Task<int> CommitAsync(); 
        void Dispose();
    }
}
