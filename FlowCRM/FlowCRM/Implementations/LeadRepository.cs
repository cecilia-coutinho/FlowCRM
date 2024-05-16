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
        public async Task<IEnumerable<Lead>> GetLeadsAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {
            var leads = _context.Leads.AsQueryable();

            // Filter
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                var validFilters = new List<string> { "FirstName", "LastName", "Email", "PhoneNumber", "Priority", "CompanyName" };
                if (!validFilters.Contains(filterOn, StringComparer.OrdinalIgnoreCase))
                {
                    throw new ArgumentException($"Invalid filter on: '{filterOn}'", "filterOn");
                }

                if (filterOn.Equals("FirstName", StringComparison.OrdinalIgnoreCase))
                {
                    leads = leads.Where(c => c.FirstName != null && c.FirstName.Contains(filterQuery));
                }
                else if (filterOn.Equals("LastName", StringComparison.OrdinalIgnoreCase))
                {
                    leads = leads.Where(c => c.LastName != null && c.LastName.Contains(filterQuery));
                }
                else if (filterOn.Equals("Email", StringComparison.OrdinalIgnoreCase))
                {
                    leads = leads.Where(c => c.Email != null && c.Email.Contains(filterQuery));
                }
                else if (filterOn.Equals("PhoneNumber", StringComparison.OrdinalIgnoreCase))
                {
                    leads = leads.Where(c => c.PhoneNumber != null && c.PhoneNumber.Contains(filterQuery))
                    ;
                }
                else if (filterOn.Equals("Priority", StringComparison.OrdinalIgnoreCase))
                {
                    leads = leads.Join(
                    _context.Priorities,
                     lead => lead.FkPriorityId,
                     priority => priority.PriorityId,
                    (lead, priority) => new { lead, priority })
                        .Where(c => c.priority.PriorityName != null && c.priority.PriorityName.Contains(filterQuery))
                        .Select(c => c.lead);
                }
                else if (filterOn.Equals("CompanyName", StringComparison.OrdinalIgnoreCase))
                {
                    leads = leads.Join(
                        _context.Companies,
                        lead => lead.FkCompanyId,
                        company => company.CompanyId,
                        (lead, company
                        ) => new { lead, company }
                        )
                        .Where(c => c.company.CompanyName != null && c.company.CompanyName.Contains(filterQuery))
                        .Select(c => c.lead);
                }
                else
                {
                    throw new ArgumentException($"Invalid filter on: '{filterOn}'", "filterOn");
                }
            }

            // Sort
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("FirstName", StringComparison.OrdinalIgnoreCase))
                {
                    leads = isAscending ? leads.OrderBy(c => c.FirstName) : leads.OrderByDescending(c => c.FirstName);
                }
                else if (sortBy.Equals("LastName", StringComparison.OrdinalIgnoreCase))
                {
                    leads = isAscending ? leads.OrderBy(c => c.LastName) : leads.OrderByDescending(c => c.LastName);
                }
                else if (sortBy.Equals("Email", StringComparison.OrdinalIgnoreCase))
                {
                    leads = isAscending ? leads.OrderBy(c => c.Email) : leads.OrderByDescending(c => c.Email);
                }
                else if (sortBy.Equals("PhoneNumber", StringComparison.OrdinalIgnoreCase))
                {
                    leads = isAscending ? leads.OrderBy(c => c.PhoneNumber) : leads.OrderByDescending(c => c.PhoneNumber);
                }
                else if (sortBy.Equals("Priority", StringComparison.OrdinalIgnoreCase))
                {
                    leads.Join(
                        _context.Priorities,
                        deal => deal.FkPriorityId,
                        priority => priority.PriorityId,
                        (deal, priority) => new
                        {
                            deal,
                            priority
                        }
                        .ToString());

                    leads = isAscending ? leads.OrderBy(c => c.Priorities) : leads.OrderByDescending(c => c.Priorities);
                }
                else if (sortBy.Equals("CompanyName", StringComparison.OrdinalIgnoreCase))
                {
                    leads.Join(
                        _context.Companies,
                        lead => lead.FkCompanyId,
                        company => company.CompanyId,
                        (lead, company) => new
                        {
                            lead,
                            company
                        }
                        .ToString());

                    leads = isAscending ? leads.OrderBy(c => c.Companies) : leads.OrderByDescending(c => c.Companies);
                }
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;

            return await leads.Skip(skipResults).Take(pageSize).ToListAsync();
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
            await _context.Leads.AddAsync(lead);
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

            existingLead.FirstName = lead.FirstName;
            existingLead.LastName = lead.LastName;
            existingLead.Email = lead.Email;
            existingLead.PhoneNumber = lead.PhoneNumber;
            existingLead.FkPriorityId = lead.FkPriorityId;
            existingLead.FkCompanyId = lead.FkCompanyId;
            existingLead.City = lead.City;
            existingLead.Country = lead.Country;
            existingLead.UpdatedAt = DateTime.Now;
            existingLead.UpdatedBy = lead.UpdatedBy;

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
