using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface IContactRepository
	{
		Task<IEnumerable<Contact>> GetContactsAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 10);
		Task<Contact> GetContactAsync(Guid id);
		Task<Contact> AddContactAsync(Contact contact);
		Task<Contact> UpdateContactAsync(Contact contact);
		Task<Contact> DeleteContactAsync(Guid id);
	}
}
