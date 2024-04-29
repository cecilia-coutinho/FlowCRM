using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface ICustomerRepository
	{
		Task<IEnumerable<Customer>> GetCustomersAsync();
		Task<Customer> GetCustomerAsync(Guid id);
		Task<Customer> AddCustomerAsync(Customer customer);
		Task<Customer> UpdateCustomerAsync(Customer customer);
		Task<Customer> DeleteCustomerAsync(Guid id);
	}
}
