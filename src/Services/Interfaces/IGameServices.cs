using Models;

namespace Services.Interfaces
{
    public interface IGameServices
    {
        Task CreateAsync(Game game);

        Task UpdateAsync(Game game);

        Task DeleteAsync(Game game);

        Task<IEnumerable<Game>> GetAllGamesAsync();

        Task<Game> GetByIdAsync(int id);

        Task<Game> GetByNameAsync(string name);
    }
}
