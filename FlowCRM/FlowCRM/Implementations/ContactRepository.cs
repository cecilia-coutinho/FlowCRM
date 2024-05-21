using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using System.Globalization;

namespace FlowCRM.Implementations
{
	public class ContactRepository : IContactRepository
	{
		private readonly ApplicationDbContext _context;

		public ContactRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Contact>> GetContactsAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
		{
            var contacts = _context.Contacts.AsQueryable();

            // Filter
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                if (filterOn.Equals("FirstName", StringComparison.OrdinalIgnoreCase))
                {
                    contacts = contacts.Where(c => c.FirstName != null && c.FirstName.Contains(filterQuery));
                }
                else if (filterOn.Equals("LastName", StringComparison.OrdinalIgnoreCase))
                {
                    contacts = contacts.Where(c => c.LastName != null && c.LastName.Contains(filterQuery));
                }
                else if (filterOn.Equals("Email", StringComparison.OrdinalIgnoreCase))
                {
                    contacts = contacts.Where(c => c.Email != null && c.Email.Contains(filterQuery));
                }
                else if (filterOn.Equals("PhoneNumber", StringComparison.OrdinalIgnoreCase))
                {
                    contacts = contacts.Where(c => c.PhoneNumber != null && c.PhoneNumber.Contains(filterQuery))
                    ;
                }
				else if (filterOn.Equals("CustomerName", StringComparison.OrdinalIgnoreCase))
				{
					contacts = contacts.Join(
						_context.Customers,
						contact => contact.FkCustomerId,
						customer => customer.CustomerId,
						(contact, customer) => new { contact, customer }
						)
						.Where(c => c.customer.FirstName != null && c.customer.FirstName.Contains(filterQuery) && c.customer.LastName != null || c.customer.LastName != null && c.customer.LastName.Contains(filterQuery))
						.Select(c => c.contact);
				}
			}

            // Sort
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("FirstName", StringComparison.OrdinalIgnoreCase))
                {
                    contacts = isAscending ? contacts.OrderBy(c => c.FirstName) : contacts.OrderByDescending(c => c.FirstName);
                }
                else if (sortBy.Equals("LastName", StringComparison.OrdinalIgnoreCase))
                {
                    contacts = isAscending ? contacts.OrderBy(c => c.LastName) : contacts.OrderByDescending(c => c.LastName);
                }
                else if (sortBy.Equals("Email", StringComparison.OrdinalIgnoreCase))
                {
                    contacts = isAscending ? contacts.OrderBy(c => c.Email) : contacts.OrderByDescending(c => c.Email);
                }
                else if (sortBy.Equals("PhoneNumber", StringComparison.OrdinalIgnoreCase))
                {
                    contacts = isAscending ? contacts.OrderBy(c => c.PhoneNumber) : contacts.OrderByDescending(c => c.PhoneNumber);
                }
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;

            return await contacts.Skip(skipResults).Take(pageSize).ToListAsync();
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
			await _context.Contacts.AddAsync(contact);
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

			existingContact.FkCustomerId = contact.FkCustomerId;
			existingContact.FkCompanyId = contact.FkCompanyId;
			existingContact.FirstName = contact.FirstName;
			existingContact.LastName = contact.LastName;
			existingContact.Email = contact.Email;
			existingContact.PhoneNumber = contact.PhoneNumber;
			existingContact.UpdatedAt = DateTime.Now;
			existingContact.UpdatedBy = contact.UpdatedBy;

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
