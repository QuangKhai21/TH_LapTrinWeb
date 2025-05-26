using NguyenTranQuangKhai.Models;

namespace NguyenTranQuangKhai.Data
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
