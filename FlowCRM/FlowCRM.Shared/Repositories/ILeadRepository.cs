using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface ILeadRepository
	{
		Task<IEnumerable<Lead>> GetLeadsAsync();
		Task<Lead> GetLeadAsync(Guid id);
		Task<Lead> AddLeadAsync(Lead lead);
		Task<Lead> UpdateLeadAsync(Lead lead);
		Task<Lead> DeleteLeadAsync(Guid id);
	}
}
