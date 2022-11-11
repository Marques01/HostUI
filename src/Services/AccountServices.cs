using Models;
using Services.Interfaces;
using System.Net.Http.Json;
using System.Security.Claims;

namespace Services
{
    public class AccountServices : IAccountServices
    {
        private HttpClient _client;

        public AccountServices(HttpClient client)
        {
            _client = client;
        }

        public Task<Claim> LoginAsync(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(UserDto userDto)
        {
            try
            {
                await _client.PostAsJsonAsync("api/Account", userDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public Task UpdateAsync(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(UserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
