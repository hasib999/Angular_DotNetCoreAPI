using EcommerceWithAngular.Web.Models;

namespace EcommerceWithAngular.Web.Services.Infrastructure
{
    public interface IOrderLine
    {
        IEnumerable<OrderLine> GetOrderLines();
        OrderLine GetOrderLine(int id);
        void Insert(OrderLine orderLine);
        void Update(OrderLine orderLine);
        void Delete(int id);
        int Count();
        void Save();
    }
}
