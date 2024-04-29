using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface IDealRepository
	{
		Task<IEnumerable<Deal>> GetDealsAsync();
		Task<Deal> GetDealAsync(Guid id);
		Task<Deal> AddDealAsync(Deal deal);
		Task<Deal> UpdateDealAsync(Deal deal);
		Task<Deal> DeleteDealAsync(Guid id);
	}
}
