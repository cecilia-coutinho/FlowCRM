using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using System.Net.Http.Json;

namespace FlowCRM.Client.Services
{
	public class ContactService : IContactRepository
	{

		private readonly HttpClient _httpClient;

		public ContactService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<IEnumerable<Contact>> GetContactsAsync()
		{
			var contacts = await _httpClient.GetAsync("api/Contacts/All-Contacts");
			var response = await contacts.Content.ReadFromJsonAsync<IEnumerable<Contact>>();

			if (response == null)
			{
				throw new Exception("Error getting contacts");
			}

			return response;
		}

		public async Task<Contact> GetContactAsync(Guid id)
		{
			var contact = await _httpClient.GetAsync($"api/Contacts/Single-Contact/{id}");
			var response = await contact.Content.ReadFromJsonAsync<Contact>();

			if (response == null)
			{
				throw new Exception("Error getting contact");
			}

			return response;
		}

		public async Task<Contact> AddContactAsync(Contact contact)
		{
			var newContact = await _httpClient.PostAsJsonAsync("api/Contacts/Add-Contact", contact);
			var response = await newContact.Content.ReadFromJsonAsync<Contact>();

			if (response == null)
			{
				throw new Exception("Error creating new contact");
			}

			return response;
		}
		public async Task<Contact> UpdateContactAsync(Contact contact)
		{
			var updatedContact = await _httpClient.PutAsJsonAsync("api/Contacts/Update-Contact", contact);
			var response = await updatedContact.Content.ReadFromJsonAsync<Contact>();

			if (response == null)
			{
				throw new Exception("Error updating contact");
			}

			return response;
		}

		public async Task<Contact> DeleteContactAsync(Guid id)
		{
			var contact = await _httpClient.DeleteAsync($"api/Contacts/{id}");
			var response = await contact.Content.ReadFromJsonAsync<Contact>();

			if (response == null)
			{
				throw new Exception("Error deleting contact");
			}

			return response;
		}
	}
}
