using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FlowCRM.Controllers
{
	[Route("api/customers")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private readonly ICustomerRepository _customerRepository;

		public CustomersController(ICustomerRepository customerRepository)
		{
			_customerRepository = customerRepository;
		}

        // GET: api/Customers/All-Customers?pageNumber=1&pageSize=1000
        [HttpGet("All-Customers")]
		public async Task<ActionResult<IEnumerable<Customer>>> GetCustomersAsync([FromQuery] string? filterOn,
            [FromQuery] string? filterQuery,
            [FromQuery] string? sortBy, [FromQuery] bool? isAscending,
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000)
		{
			var customers = await _customerRepository.GetCustomersAsync(filterOn,
                filterQuery,
                sortBy,
                isAscending ?? true,
                pageNumber,
                pageSize);
			return Ok(customers);
		}

		// GET: api/Customers/Single-Customer/5
		[HttpGet("Single-Customer/{id}")]
		public async Task<ActionResult<Customer>> GetCustomerAsync(Guid id)
		{
			var customer = await _customerRepository.GetCustomerAsync(id);
			return Ok(customer);
		}

		// POST: api/Customers/Add-Customer
		[HttpPost("Add-Customer")]
		//[Authorize(Roles = "Admin")]
		public async Task<ActionResult<Customer>> AddCustomerAsync(Customer customer)
		{
			string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			customer.CreatedBy = userId;

			var newCustomer = await _customerRepository.AddCustomerAsync(customer);
			return CreatedAtAction("GetCustomer", new { id = newCustomer.CustomerId }, newCustomer);
		}

		// PUT: api/Customers/Update-Customer
		[HttpPut("Update-Customer")]
		public async Task<IActionResult> UpdateCustomerAsync(Customer customer)
		{
			string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			customer.UpdatedBy = userId;

			var updatedCustomer = await _customerRepository.UpdateCustomerAsync(customer);

			return Ok(updatedCustomer);
		}

		//DELETE: api/Customers/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCustomerAsync(Guid id)
		{
			var customer = await _customerRepository.DeleteCustomerAsync(id);
			return Ok(customer);
		}
	}
}
