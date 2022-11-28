using Models;

namespace Services.Interfaces
{
    public interface ICapacityServices
    {
        Task CreateAsync(Capacity capacity);

        Task UpdateAsync(Capacity capacity);

        Task DeleteAsync(Capacity capacity);

        Task<IEnumerable<Capacity>> GetAllCapacitiesAsync();

        Task<IEnumerable<Capacity>> GetBySlotsAsync(int slots);

        Task<Capacity> GetBydIdAsync(int id);
    }
}
