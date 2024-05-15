using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface IDealRepository
	{
		Task<IEnumerable<Deal>> GetDealsAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000);
		Task<Deal> GetDealAsync(Guid id);
		Task<Deal> AddDealAsync(Deal deal);
		Task<Deal> UpdateDealAsync(Deal deal);
		Task<Deal> DeleteDealAsync(Guid id);
	}
}
