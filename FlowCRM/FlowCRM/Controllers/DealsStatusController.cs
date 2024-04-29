using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FlowCRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealsStatusController : Controller
    {
        private readonly IDealStatusRepository _dealStatusRepository;

        public DealsStatusController(IDealStatusRepository dealStatusRepository)
        {
            _dealStatusRepository = dealStatusRepository;
        }

        // GET: api/DealsStatus/All-Deals-Status
        [HttpGet("All-Deals-Status")]
        public async Task<ActionResult<IEnumerable<DealStatus>>> GetDealStatusesAsync()
        {
            var dealStatus = await _dealStatusRepository.GetDealStatusesAsync();
            return Ok(dealStatus);
        }

        // GET: api/DealsStatus/Single-Deal-Status/5
        [HttpGet("Single-Deal-Status/{id}")]
        public async Task<ActionResult<DealStatus>> GetDealStatusAsync(Guid id)
        {
            var dealStatus = await _dealStatusRepository.GetDealStatusAsync(id);
            return Ok(dealStatus);
        }
    }
}
