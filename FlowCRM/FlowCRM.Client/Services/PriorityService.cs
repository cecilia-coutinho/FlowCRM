using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using System.Net.Http.Json;

namespace FlowCRM.Client.Services
{
    public class PriorityService : IPriorityRepository
    {
        private readonly HttpClient _httpClient;
        public PriorityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Priority>> GetPrioritiesAsync()
        {
            var priorities = await _httpClient.GetAsync("api/Priorities/All-Priorities");
            var response = await priorities.Content.ReadFromJsonAsync<IEnumerable<Priority>>();

            if (response == null)
            {
                throw new Exception("Error getting priorities");
            }

            return response;
        }

        public async Task<Priority> GetPriorityAsync(Guid id)
        {
            var priority = await _httpClient.GetAsync($"api/Priorities/Single-Priority/{id}");
            var response = await priority.Content.ReadFromJsonAsync<Priority>();

            if (response == null)
            {
                throw new Exception("Error getting priority");
            }

            return response;
        }
    }
}
