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
	public class DealsController : ControllerBase
	{
		private readonly IDealRepository _dealRepository;

		public DealsController(IDealRepository dealRepository)
		{
			_dealRepository = dealRepository;
		}

		// GET: api/Deals/All-Deals
		[HttpGet("All-Deals")]
		public async Task<ActionResult<IEnumerable<Deal>>> GetDeals()
		{
			var deals = await _dealRepository.GetDealsAsync();
			return Ok(deals);
		}

		// GET: api/Deals/Single-Deal/5
		[HttpGet("Single-Deal/{id}")]
		public async Task<ActionResult<Deal>> GetDeal(Guid id)
		{
			var deal = await _dealRepository.GetDealAsync(id);
			return deal;
		}

		// POST: api/Deals/Add-Deal
		[HttpPost("Add-Deal")]
		public async Task<ActionResult<Deal>> PostDeal(Deal deal)
		{
			string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			deal.CreatedBy = userId;

			var newDeal = await _dealRepository.AddDealAsync(deal);
			return CreatedAtAction("GetDeal", new { id = newDeal.DealId }, newDeal);
		}

		// PUT: api/Deals/Update-Deal
		[HttpPut("Update-Deal")]
		public async Task<IActionResult> PutDeal(Deal deal)
		{
			string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			deal.UpdatedBy = userId;

			var updatedDeal = await _dealRepository.UpdateDealAsync(deal);
			return Ok(updatedDeal);
		}


		// DELETE: api/Deals/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteDeal(Guid id)
		{
			var deal = await _dealRepository.DeleteDealAsync(id);
			return Ok(deal);
		}
	}
}
