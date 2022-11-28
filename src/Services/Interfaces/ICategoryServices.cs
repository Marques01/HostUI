using Models;

namespace Services.Interfaces
{
    public interface ICategoryServices
    {
        Task Create(Category category);

        void Update(Category category);

        void Delete(Category category);

        Task<IEnumerable<Category>> GetCategories();

        Task<IEnumerable<Category>> GetByName(string name);

        Task<Category> GetById(int id);        
    }
}
