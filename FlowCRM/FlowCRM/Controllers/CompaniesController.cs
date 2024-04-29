using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FlowCRM.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompaniesController : ControllerBase
	{
		private readonly ICompanyRepository _companyRepository;

		public CompaniesController(ICompanyRepository companyRepository)
		{
			_companyRepository = companyRepository;
		}

		// GET: api/Companies/All-Companies
		[HttpGet("All-Companies")]
		public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
		{
			var companies = await _companyRepository.GetCompaniesAsync();
			return Ok(companies);
		}

		// GET: api/Companies/Single-Company/5
		[HttpGet("Single-Company/{id}")]
		public async Task<ActionResult<Company>> GetCompany(Guid id)
		{
			var company = await _companyRepository.GetCompanyAsync(id);
			return Ok(company);
		}

		// POST: api/Companies/Add-Company
		[HttpPost("Add-Company")]
		public async Task<ActionResult<Company>> PostCompany(Company company)
		{
			string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			company.CreatedBy = userId;

			var newCompany = await _companyRepository.AddCompanyAsync(company);
			return CreatedAtAction("GetCompany", new { id = newCompany.CompanyId }, newCompany);
		}

		// PUT: api/Companies/Update-Company
		[HttpPut("Update-Company")]
		public async Task<IActionResult> PutCompany(Company company)
		{
			string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			company.UpdatedBy = userId;

			var updatedCompany = await _companyRepository.UpdateCompanyAsync(company);

			return Ok(updatedCompany);
		}

		// DELETE: api/Companies/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCompany(Guid id)
		{
			var company = await _companyRepository.DeleteCompanyAsync(id);

			return Ok(company);
		}
	}
}
