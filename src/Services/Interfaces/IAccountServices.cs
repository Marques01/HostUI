using Models;
using System.Security.Claims;

namespace Services.Interfaces
{
    public interface IAccountServices
    {
        Task<Claim> LoginAsync(UserDto userDto);

        Task CreateAsync(UserDto userDto);

        Task DeleteAsync(UserDto userDto);

        Task UpdateAsync(UserDto userDto);
    }
}
