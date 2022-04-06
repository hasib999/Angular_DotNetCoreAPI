using EcommerceWithAngular.Web.Models;

namespace EcommerceWithAngular.Web.Services.Infrastructure
{
    public interface IPicture
    {
        Picture GetPicture(int id);
        void Insert(Picture picture);
        void Update(Picture picture);
        void Delete(int id);
        int Count();
        void Save();
    }
}
