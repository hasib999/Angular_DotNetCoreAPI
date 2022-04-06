using EcommerceWithAngular.Web.Models;

namespace EcommerceWithAngular.Web.Services.Infrastructure
{
    public interface ICartItem
    {
        IEnumerable<CartItem> GetCartItems();
        CartItem GetCartItem(int id);
        void Insert(CartItem cartItem);
        void Update(CartItem cartItem);
        void Delete(int id);
        int Count();
        void Save();
    }
}
