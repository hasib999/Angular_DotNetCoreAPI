using EcommerceWithAngular.Web.Data;
using EcommerceWithAngular.Web.Models;
using EcommerceWithAngular.Web.Services.Infrastructure;

namespace EcommerceWithAngular.Web.Services.Repositories
{
    public class PictureRepository : IPicture
    {
        private ApplicationDbContext _context;
        public PictureRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int Count()
        {
            return _context.Pictures.Count();
        }

        public void Delete(int id)
        {
            var picture = _context.Pictures.FirstOrDefault(c => c.Id == id);
            if (picture != null)
            {
                _context.Pictures.Remove(picture);
            }
        }

        public Picture GetPicture(int id)
        {
            var picture = _context.Pictures.FirstOrDefault(c => c.Id == id);
            if (picture != null)
            {
                return picture;
            }
            return null;
        }

        public void Insert(Picture picture)
        {
            _context.Pictures.Add(picture);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Picture picture)
        {
            _context.Update(picture);
        }
    }
}
