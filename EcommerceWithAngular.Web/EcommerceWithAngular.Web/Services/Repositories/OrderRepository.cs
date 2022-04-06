using EcommerceWithAngular.Web.Data;
using EcommerceWithAngular.Web.Models;
using EcommerceWithAngular.Web.Services.Infrastructure;

namespace EcommerceWithAngular.Web.Services.Repositories
{
    public class OrderRepository : IOrder
    {
        private ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Orders.Count();
        }

        public void Delete(int id)
        {
            var order = _context.Orders.FirstOrDefault(c => c.Id == id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }
        }

        public Order GetOrder(int id)
        {
            var order = _context.Orders.FirstOrDefault(c => c.Id == id);
            if (order != null)
            {
                return order;
            }
            return null;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
