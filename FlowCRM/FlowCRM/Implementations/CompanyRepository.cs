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

		public async Task<IEnumerable<Company>> GetCompaniesAsync()
		{
			return await _context.Companies.ToListAsync();
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
			_context.Companies.Add(company);
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
