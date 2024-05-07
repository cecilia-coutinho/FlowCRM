using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface ICustomerRepository
	{
        Task<IEnumerable<Customer>> GetCustomersAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 10);
		Task<Customer> GetCustomerAsync(Guid id);
		Task<Customer> AddCustomerAsync(Customer customer);
		Task<Customer> UpdateCustomerAsync(Customer customer);
		Task<Customer> DeleteCustomerAsync(Guid id);
	}
}
