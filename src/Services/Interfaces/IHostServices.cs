using Models;

namespace Services.Interfaces
{
    public interface IHostServices
    {
        Task<Host> GetByIdAsync(int id);

        Task<Host> GetByNameAsync(string name);

        Task<IEnumerable<Host>> GetByStatusAsync(bool situation);

        Task<Host> GetByDoorAsync(int door);

        Task<IEnumerable<Host>> GetAllHostsAsync();

        Task DisableHostAsync(Host host);

        Task CreateHostAsync(Host host);

        Task DeleteHostAsync(Host host);

        Task UpdateAsync(Host host);
    }
}
