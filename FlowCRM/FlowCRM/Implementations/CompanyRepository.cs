using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
	public class CompanyRepository : ICompanyRepository
	{
		private readonly ApplicationDbContext _context;

		public CompanyRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Company>> GetCompaniesAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
		{
            var companies = _context.Companies.AsQueryable();

            // Filter
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                if (filterOn.Equals("CompanyName", StringComparison.OrdinalIgnoreCase))
                {
                    companies = companies.Where(c => c.CompanyName != null && c.CompanyName.Contains(filterQuery));
                }
                else if (filterOn.Equals("CompanyEmailAddress", StringComparison.OrdinalIgnoreCase))
                {
                    companies = companies.Where(c => c.CompanyEmailAddress != null && c.CompanyEmailAddress.Contains(filterQuery));
                }
                else if (filterOn.Equals("City", StringComparison.OrdinalIgnoreCase))
                {
                    companies = companies.Where(c => c.City != null && c.City.Contains(filterQuery));
                }
                else if (filterOn.Equals("Country", StringComparison.OrdinalIgnoreCase))
                {
                    companies = companies.Where(c => c.Country != null && c.Country.Contains(filterQuery))
                    ;
                }
                else
                {
                    throw new ArgumentException($"Invalid filter on: '{filterOn}'", "filterOn");
                }
            }

            // Sort
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("CompanyName", StringComparison.OrdinalIgnoreCase))
                {
                    companies = isAscending ? companies.OrderBy(c => c.CompanyName) : companies.OrderByDescending(c => c.CompanyName);
                }
                else if (sortBy.Equals("CompanyEmailAddress", StringComparison.OrdinalIgnoreCase))
                {
                    companies = isAscending ? companies.OrderBy(c => c.CompanyEmailAddress) : companies.OrderByDescending(c => c.CompanyEmailAddress);
                }
                else if (sortBy.Equals("City", StringComparison.OrdinalIgnoreCase))
                {
                    companies = isAscending ? companies.OrderBy(c => c.City) : companies.OrderByDescending(c => c.City);
                }
                else if (sortBy.Equals("Country", StringComparison.OrdinalIgnoreCase))
                {
                    companies = isAscending ? companies.OrderBy(c => c.Country) : companies.OrderByDescending(c => c.Country);
                }
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;

            return await companies.Skip(skipResults).Take(pageSize).ToListAsync();
        }

		public async Task<Company> GetCompanyAsync(Guid id)
		{
			var company = await _context.Companies.FindAsync(id);

			if (company == null)
			{
				throw new Exception($"No company found with ID {id}");
			}

			return company;
		}

		public async Task<Company> AddCompanyAsync(Company company)
		{
			if (company == null)
			{
				throw new Exception($"No company found: {company}");
			}

			company.CreatedAt = DateTime.Now;
			await _context.Companies.AddAsync(company);
			await _context.SaveChangesAsync();
			return company;
		}

		public async Task<Company> UpdateCompanyAsync(Company company)
		{
			var existingCompany = await _context.Companies.FindAsync(company.CompanyId);

			if (existingCompany == null)
			{
				throw new Exception($"No company found: {company}");
			}

			existingCompany = company;
			existingCompany.UpdatedAt = DateTime.Now;
			_context.Entry(existingCompany).State = EntityState.Modified;
			await _context.SaveChangesAsync();
			return existingCompany;
		}
		public async Task<Company> DeleteCompanyAsync(Guid id)
		{
			var company = await _context.Companies.FindAsync(id);

			if (company == null)
			{
				throw new Exception($"No company found with ID {id}");
			}

			_context.Companies.Remove(company);
			await _context.SaveChangesAsync();
			return company;
		}
	}
}
