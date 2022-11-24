using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface ICartRepository : IRepository<Cart>
    {
        Cart GetCartByUserId(string userId);
        void DeleteFromCart(int cartId, int productId);
        void ClearCart(int cartId);
    }
}