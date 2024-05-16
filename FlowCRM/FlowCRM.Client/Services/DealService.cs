using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using System.Net.Http.Json;

namespace FlowCRM.Client.Services
{
	public class DealService : IDealRepository
	{
		private readonly HttpClient _httpClient;

		public DealService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<IEnumerable<Deal>> GetDealsAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
		{
			var deals = await _httpClient.GetAsync("api/Deals/All-Deals");
			var response = await deals.Content.ReadFromJsonAsync<IEnumerable<Deal>>();

			if (response == null)
			{
				throw new Exception("Error getting deals");
			}

			return response;
		}

		public async Task<Deal> GetDealAsync(Guid id)
		{
			var deal = await _httpClient.GetAsync($"api/Deals/Single-Deal/{id}");
			var response = await deal.Content.ReadFromJsonAsync<Deal>();

			if (response == null)
			{
				throw new Exception("Error getting deal");
			}

			return response;
		}

		public async Task<Deal> AddDealAsync(Deal deal)
		{
			var newDeal = await _httpClient.PostAsJsonAsync("api/Deals/Add-Deal", deal);
			var response = await newDeal.Content.ReadFromJsonAsync<Deal>();

			if (response == null)
			{
				throw new Exception("Error creating new deal");
			}

			return response;
		}

		public async Task<Deal> UpdateDealAsync(Deal deal)
		{
			var updatedDeal = await _httpClient.PutAsJsonAsync("api/Deals/Update-Deal", deal);
			var response = await updatedDeal.Content.ReadFromJsonAsync<Deal>();

			if (response == null)
			{
				throw new Exception("Error updating deal");
			}

			return response;
		}

		public async Task<Deal> DeleteDealAsync(Guid id)
		{
			var deal = await _httpClient.DeleteAsync($"api/Deals/{id}");
			var response = await deal.Content.ReadFromJsonAsync<Deal>();

			if (response == null)
			{
				throw new Exception("Error deleting deal");
			}

			return response;
		}
	}
}
