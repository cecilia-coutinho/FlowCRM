using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using System.Net.Http.Json;

namespace FlowCRM.Client.Services
{
	public class CompanyService : ICompanyRepository
	{
		private readonly HttpClient _httpClient;

		public CompanyService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<IEnumerable<Company>> GetCompaniesAsync()
		{
			var companies = await _httpClient.GetAsync("api/Companies/All-Companies");
			var response = await companies.Content.ReadFromJsonAsync<IEnumerable<Company>>();

			if (response == null)
			{
				throw new Exception("Error getting companies");
			}

			return response;
		}

		public async Task<Company> GetCompanyAsync(Guid id)
		{
			var company = await _httpClient.GetAsync($"api/Companies/Single-Company/{id}");
			var response = await company.Content.ReadFromJsonAsync<Company>();

			if (response == null)
			{
				throw new Exception("Error getting company");
			}

			return response;
		}

		public async Task<Company> AddCompanyAsync(Company company)
		{
			var newCompany = await _httpClient.PostAsJsonAsync("api/Companies/Add-Company", company);
			var response = await newCompany.Content.ReadFromJsonAsync<Company>();

			if (response == null)
			{
				throw new Exception("Error creating new company");
			}

			return response;
		}
		public async Task<Company> UpdateCompanyAsync(Company company)
		{
			var updatedCompany = await _httpClient.PutAsJsonAsync("api/Companies/Update-Company", company);
			var response = await updatedCompany.Content.ReadFromJsonAsync<Company>();

			if (response == null)
			{
				throw new Exception("Error updating company");
			}

			return response;
		}

		public async Task<Company> DeleteCompanyAsync(Guid id)
		{
			var company = await _httpClient.DeleteAsync($"api/Companies/{id}");
			var response = await company.Content.ReadFromJsonAsync<Company>();

			if (response == null)
			{
				throw new Exception("Error deleting company");
			}

			return response;
		}

	}
}
