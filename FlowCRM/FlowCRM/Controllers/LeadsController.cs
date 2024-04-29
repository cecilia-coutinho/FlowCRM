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
	public class LeadsController : ControllerBase
	{
		private readonly ILeadRepository _leadRepository;

		public LeadsController(ILeadRepository leadRepository)
		{
			_leadRepository = leadRepository;
		}

		// GET: api/Leads/All-Leads
		[HttpGet("All-Leads")]
		public async Task<ActionResult<IEnumerable<Lead>>> GetLeads()
		{
			var leads = await _leadRepository.GetLeadsAsync();
			return Ok(leads);
		}

		// GET: api/Leads/Single-Lead/5
		[HttpGet("Single-Lead/{id}")]
		public async Task<ActionResult<Lead>> GetLead(Guid id)
		{
			var lead = await _leadRepository.GetLeadAsync(id);
			return Ok(lead);
		}

		// POST: api/Leads/Add-Lead
		[HttpPost("Add-Lead")]
		public async Task<ActionResult<Lead>> PostLead(Lead lead)
		{
			string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			lead.CreatedBy = userId;

			var newLead = await _leadRepository.AddLeadAsync(lead);
			return CreatedAtAction("GetLead", new { id = newLead.LeadId }, newLead);
		}

		// PUT: api/Leads/Update-Lead
		[HttpPut("Update-Lead")]
		public async Task<IActionResult> PutLead(Lead lead)
		{
			string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			lead.UpdatedBy = userId;

			var updatedLead = await _leadRepository.UpdateLeadAsync(lead);

			return Ok(updatedLead);
		}


		// DELETE: api/Leads/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteLead(Guid id)
		{
			var lead = await _leadRepository.DeleteLeadAsync(id);
			return Ok(lead);
		}
	}
}
