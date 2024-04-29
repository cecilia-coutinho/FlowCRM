using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
	public class ContactRepository : IContactRepository
	{
		private readonly ApplicationDbContext _context;

		public ContactRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Contact>> GetContactsAsync()
		{
			return await _context.Contacts.ToListAsync();
		}
		public async Task<Contact> GetContactAsync(Guid id)
		{
			var contact = await _context.Contacts.FindAsync(id);

			if (contact == null)
			{
				throw new Exception($"No contact found with ID {id}");
			}

			return contact;
		}

		public async Task<Contact> AddContactAsync(Contact contact)
		{
			if (contact == null)
			{
				throw new Exception($"No contact found: {contact}");
			}

			contact.CreatedAt = DateTime.Now;
			_context.Contacts.Add(contact);
			await _context.SaveChangesAsync();
			return contact;
		}

		public async Task<Contact> UpdateContactAsync(Contact contact)
		{
			var existingContact = await _context.Contacts.FindAsync(contact.ContactId);

			if (existingContact == null)
			{
				throw new Exception($"No contact found: {contact}");
			}

			existingContact = contact;
			existingContact.UpdatedAt = DateTime.Now;
			_context.Entry(existingContact).State = EntityState.Modified;
			await _context.SaveChangesAsync();
			return existingContact;
		}

		public async Task<Contact> DeleteContactAsync(Guid id)
		{
			var contact = await _context.Contacts.FindAsync(id);

			if (contact == null)
			{
				throw new Exception($"No contact found with ID {id}");
			}

			_context.Contacts.Remove(contact);
			await _context.SaveChangesAsync();
			return contact;
		}
	}
}
