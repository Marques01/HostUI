using Models;

namespace Services.Interfaces
{
    public interface IHostCapacityServices
    {
        Task CreateAsync(HostCapacity hostCapacity);

        Task UpdateAsync(HostCapacity hostCapacity);

        Task DeleteAsync(HostCapacity hostCapacity);

        Task<HostCapacity> GetByIdAsync(int id);

        Task<HostCapacity> GetByGameCapacityId(int id);

        Task<IEnumerable<HostCapacity>> GetAllHostCapacitiesAsync();
    }
}
