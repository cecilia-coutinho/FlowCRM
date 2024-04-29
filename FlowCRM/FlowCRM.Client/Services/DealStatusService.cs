using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using System.Net.Http.Json;

namespace FlowCRM.Client.Services
{
    public class DealStatusService : IDealStatusRepository
    {
        private readonly HttpClient _httpClient;

        public DealStatusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<DealStatus>> GetDealStatusesAsync()
        {
            var dealStatus = await _httpClient.GetAsync("api/DealsStatus/All-Deals-Status");
            var response = await dealStatus.Content.ReadFromJsonAsync<IEnumerable<DealStatus>>();

            if (response == null)
            {
                throw new Exception("Error getting deal status");
            }

            return response;
        }

        public async Task<DealStatus> GetDealStatusAsync(Guid id)
        {
            var dealStatus = await _httpClient.GetAsync($"api/DealsStatus/Single-Deal-Status/{id}");
            var response = await dealStatus.Content.ReadFromJsonAsync<DealStatus>();

            if (response == null)
            {
                throw new Exception("Error getting deal status");
            }

            return response;
        }

    }
}
