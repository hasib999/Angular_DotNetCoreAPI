using EcommerceWithAngular.Web.Data;
using EcommerceWithAngular.Web.Models;
using EcommerceWithAngular.Web.Services.Infrastructure;

namespace EcommerceWithAngular.Web.Services.Repositories
{
    public class ProductRepository : IProduct
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Products.Count();
        }

        public void Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(c => c.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
        }

        public Product GetProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(c => c.Id == id);
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public void Insert(Product product)
        {
            _context.Products.Add(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Update(product);
        }
    }
}
