using Models;

namespace Services.Interfaces
{
    public interface ICategoryProductServices
    {
        Task<IEnumerable<CategoryProduct>> GetProductsByCategory(int categoryId);
    }
}
