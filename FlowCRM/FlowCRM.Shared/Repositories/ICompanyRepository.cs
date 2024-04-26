using FlowCRM.Shared.Entities;

namespace FlowCRM.Shared.Repositories
{
	public interface ICompanyRepository
	{
		Task<IEnumerable<Company>> GetCompaniesAsync();
		Task<Company> GetCompanyAsync(Guid id);
		Task<Company> AddCompanyAsync(Company company);
		Task<Company> UpdateCompanyAsync(Company company);
		Task<Company> DeleteCompanyAsync(Guid id);
	}
}
