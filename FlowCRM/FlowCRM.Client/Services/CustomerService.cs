using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using System.Net.Http.Json;

namespace FlowCRM.Client.Services
{
    public class CustomerService : ICustomerRepository
    {
        private readonly HttpClient _httpClient;

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {
            var customers = await _httpClient.GetAsync($"api/Customers/All-Customers");
            var response = await customers.Content.ReadFromJsonAsync<IEnumerable<Customer>>();

            if (response == null)
            {
                throw new Exception("Error getting customers");
            }

            return response;
        }

        public async Task<Customer> GetCustomerAsync(Guid id)
        {
            var customer = await _httpClient.GetAsync($"api/Customers/Single-Customer/{id}");
            var response = await customer.Content.ReadFromJsonAsync<Customer>();

            if (response == null)
            {
                throw new Exception("Error getting customer");
            }

            return response;
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            var newCustomer = await _httpClient.PostAsJsonAsync("api/Customers/Add-Customer", customer);
            var response = await newCustomer.Content.ReadFromJsonAsync<Customer>();

            if (response == null)
            {
                throw new Exception("Error creating new customer");
            }

            return response;
        }


        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            var updatedCustomer = await _httpClient.PutAsJsonAsync("api/Customers/Update-Customer", customer);
            var response = await updatedCustomer.Content.ReadFromJsonAsync<Customer>();

            if (response == null)
            {
                throw new Exception("Error updating customer");
            }

            return response;
        }


        public async Task<Customer> DeleteCustomerAsync(Guid id)
        {
            var customer = await _httpClient.DeleteAsync($"api/Customers/{id}");
            var response = await customer.Content.ReadFromJsonAsync<Customer>();


            if (response == null)
            {
                throw new Exception("Error deleting customer");
            }

            return response;
        }
    }
}
