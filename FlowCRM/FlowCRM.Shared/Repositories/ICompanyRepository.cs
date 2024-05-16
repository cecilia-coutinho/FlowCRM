using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface ICompanyRepository
	{
		Task<IEnumerable<Company>> GetCompaniesAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 10);
		Task<Company> GetCompanyAsync(Guid id);
		Task<Company> AddCompanyAsync(Company company);
		Task<Company> UpdateCompanyAsync(Company company);
		Task<Company> DeleteCompanyAsync(Guid id);
	}
}
