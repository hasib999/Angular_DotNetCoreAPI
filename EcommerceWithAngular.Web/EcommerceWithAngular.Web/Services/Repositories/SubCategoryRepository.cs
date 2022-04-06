using EcommerceWithAngular.Web.Data;
using EcommerceWithAngular.Web.Models;
using EcommerceWithAngular.Web.Services.Infrastructure;

namespace EcommerceWithAngular.Web.Services.Repositories
{
    public class SubCategoryRepository : ISubCategory
    {
        private ApplicationDbContext _context;
        public SubCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.SubCategories.Count();
        }

        public void Delete(int id)
        {
            var subCategory = _context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subCategory != null)
            {
                _context.SubCategories.Remove(subCategory);
            }
        }

        public IEnumerable<SubCategory> GetSubCategories()
        {
            return _context.SubCategories;
        }

        public SubCategory GetSubCategory(int id)
        {
            var subCategory = _context.SubCategories.FirstOrDefault(c => c.Id == id);
            if (subCategory != null)
            {
                return subCategory;
            }
            return null;
        }

        public void Insert(SubCategory subCategory)
        {
            _context.SubCategories.Add(subCategory);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(SubCategory subCategory)
        {
            _context.Update(subCategory);
        }
    }
}
