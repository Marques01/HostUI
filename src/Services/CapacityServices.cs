using Microsoft.JSInterop;
using Models;
using Services.Authentication;
using Services.Interfaces;
using Services.Utils;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Services
{
    public class CapacityServices : ICapacityServices
    {
        private HttpClient _client;

        IJSRuntime _js;

        public CapacityServices(HttpClient client, IJSRuntime js)
        {
            _client = client;

            _js = js;
        }

        public Task CreateAsync(Capacity capacity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Capacity capacity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Capacity>> GetAllCapacitiesAsync()
        {
            try
            {
                var token = await _js.GetFromLocalStorage(TokenAuthenticationProvider.TokenKey);

                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

                var capacity = await _client.GetFromJsonAsync<IEnumerable<Capacity>>("api/capacity/all");

                if (capacity != null)
                    return capacity;

                return Enumerable.Empty<Capacity>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<Capacity> GetBydIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Capacity>> GetBySlotsAsync(int slots)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Capacity capacity)
        {
            throw new NotImplementedException();
        }
    }
}
