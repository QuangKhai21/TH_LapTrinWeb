using NguyenTranQuangKhai.Models;

namespace NguyenTranQuangKhai.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }

}
