using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
	public class LeadRepository : ILeadRepository
	{

		private readonly ApplicationDbContext _context;

		public LeadRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public async Task<IEnumerable<Lead>> GetLeadsAsync()
		{
			return await _context.Leads.ToListAsync();
		}

		public async Task<Lead> GetLeadAsync(Guid id)
		{
			var lead = await _context.Leads.FindAsync(id);

			if (lead == null)
			{
				throw new Exception($"No lead found with ID {id}");
			}
			return lead;
		}

		public async Task<Lead> AddLeadAsync(Lead lead)
		{
			if (lead == null)
			{
				throw new Exception($"No lead found: {lead}");
			}

			lead.CreatedAt = DateTime.Now;
			_context.Leads.Add(lead);
			await _context.SaveChangesAsync();
			return lead;
		}
		public async Task<Lead> UpdateLeadAsync(Lead lead)
		{
			var existingLead = await _context.Leads.FindAsync(lead.LeadId);

			if (existingLead == null)
			{
				throw new Exception($"No lead found: {lead}");
			}

			existingLead = lead;
			existingLead.UpdatedAt = DateTime.Now;
			_context.Entry(existingLead).State = EntityState.Modified;
			await _context.SaveChangesAsync();
			return existingLead;
		}

		public async Task<Lead> DeleteLeadAsync(Guid id)
		{
			var lead = await _context.Leads.FindAsync(id);

			if (lead == null)
			{
				throw new Exception($"No lead found with ID {id}");
			}

			_context.Leads.Remove(lead);
			await _context.SaveChangesAsync();
			return lead;
		}
	}
}
