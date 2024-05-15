using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FlowCRM.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactsController : ControllerBase
	{
		private readonly IContactRepository _contactRepository;

		public ContactsController(IContactRepository contactRepository)
		{
			_contactRepository = contactRepository;
		}

        // GET: api/Contacts/All-Contacts?pageNumber=1&pageSize=1000
        [HttpGet("All-Contacts")]
		public async Task<ActionResult<IEnumerable<Contact>>> GetContacts([FromQuery] string? filterOn,
            [FromQuery] string? filterQuery,
            [FromQuery] string? sortBy, [FromQuery] bool? isAscending,
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000)
		{
			var contacts = await _contactRepository.GetContactsAsync(filterOn,
                filterQuery,
                sortBy,
                isAscending ?? true,
                pageNumber,
                pageSize);
			return Ok(contacts);
		}

		// GET: api/Contacts/Single-Contact/5
		[HttpGet("Single-Contact/{id}")]
		public async Task<ActionResult<Contact>> GetContact(Guid id)
		{
			var contact = await _contactRepository.GetContactAsync(id);
			return Ok(contact);
		}
		// POST: api/Contacts/Add-Contact
		[HttpPost("Add-Contact")]
		public async Task<ActionResult<Contact>> PostContact(Contact contact)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			contact.CreatedBy = userId;

			var newContact = await _contactRepository.AddContactAsync(contact);
			return CreatedAtAction("GetContact", new { id = newContact.ContactId }, newContact);
		}

		// PUT: api/Contacts/Update-Contact
		[HttpPut("Update-Contact")]
		public async Task<IActionResult> PutContact(Contact contact)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			contact.UpdatedBy = userId;

			var updatedContact = await _contactRepository.UpdateContactAsync(contact);

			return Ok(updatedContact);
		}


		// DELETE: api/Contacts/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteContact(Guid id)
		{
			var contact = await _contactRepository.DeleteContactAsync(id);
			return Ok(contact);
		}
	}
}
