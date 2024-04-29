using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using System.Net.Http.Json;

namespace FlowCRM.Client.Services
{
	public class LeadService : ILeadRepository
	{
		private readonly HttpClient _httpClient;

		public LeadService(HttpClient httpClient) 
		{ 
			_httpClient = httpClient;
		}

		public async Task<IEnumerable<Lead>> GetLeadsAsync()
		{
			var leads = await _httpClient.GetAsync("api/Leads/All-Leads");
			var response = await leads.Content.ReadFromJsonAsync<IEnumerable<Lead>>();

			if (response == null)
			{
				throw new Exception("Error getting leads");
			}

			return response;
		}

		public async Task<Lead> GetLeadAsync(Guid id)
		{
			var lead = await _httpClient.GetAsync($"api/Leads/Single-Lead/{id}");
			var response = await lead.Content.ReadFromJsonAsync<Lead>();

			if (response == null)
			{
				throw new Exception("Error getting lead");
			}

			return response;
		}

		public async Task<Lead> AddLeadAsync(Lead lead)
		{
			var newLead = await _httpClient.PostAsJsonAsync("api/Leads/Add-Lead", lead);
			var response = await newLead.Content.ReadFromJsonAsync<Lead>();

			if (response == null)
			{
				throw new Exception("Error creating new lead");
			}

			return response;
		}

		public async Task<Lead> UpdateLeadAsync(Lead lead)
		{
			var updatedLead = await _httpClient.PutAsJsonAsync("api/Leads/Update-Lead", lead);
			var response = await updatedLead.Content.ReadFromJsonAsync<Lead>();

			if (response == null)
			{
				throw new Exception("Error updating lead");
			}

			return response;
		}

		public async Task<Lead> DeleteLeadAsync(Guid id)
		{
			var lead = await _httpClient.DeleteAsync($"api/Leads/{id}");
			var response = await lead.Content.ReadFromJsonAsync<Lead>();

			if (response == null)
			{
				throw new Exception("Error deleting lead");
			}

			return response;
		}
	}
}
