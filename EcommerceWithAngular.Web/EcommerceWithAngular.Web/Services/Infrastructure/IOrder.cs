using EcommerceWithAngular.Web.Models;

namespace EcommerceWithAngular.Web.Services.Infrastructure
{
    public interface IOrder
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void Delete(int id);
        int Count();
        void Save();
    }
}
