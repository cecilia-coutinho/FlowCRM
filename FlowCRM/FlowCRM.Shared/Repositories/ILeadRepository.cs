using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface ILeadRepository
	{
		Task<IEnumerable<Lead>> GetLeadsAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 10);
		Task<Lead> GetLeadAsync(Guid id);
		Task<Lead> AddLeadAsync(Lead lead);
		Task<Lead> UpdateLeadAsync(Lead lead);
		Task<Lead> DeleteLeadAsync(Guid id);
	}
}
