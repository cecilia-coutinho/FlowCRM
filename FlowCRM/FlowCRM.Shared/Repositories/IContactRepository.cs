using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface IContactRepository
	{
		Task<IEnumerable<Contact>> GetContactsAsync();
		Task<Contact> GetContactAsync(Guid id);
		Task<Contact> AddContactAsync(Contact contact);
		Task<Contact> UpdateContactAsync(Contact contact);
		Task<Contact> DeleteContactAsync(Guid id);
	}
}
