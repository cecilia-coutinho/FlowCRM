using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FlowCRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrioritiesController : ControllerBase
    {
        private readonly IPriorityRepository _priorityRepository;

        public PrioritiesController(IPriorityRepository priorityRepository)
        {
            _priorityRepository = priorityRepository;
        }

        // GET: api/Priorities/All-Priorities
        [HttpGet("All-Priorities")]
        public async Task<ActionResult<IEnumerable<Priority>>> GetPriorities()
        {
            var priorities = await _priorityRepository.GetPrioritiesAsync();
            return Ok(priorities);
        }

        // GET: api/Priorities/Single-Priority/5
        [HttpGet("Single-Priority/{id}")]
        public async Task<ActionResult<Priority>> GetPriority(Guid id)
        {
            var priority = await _priorityRepository.GetPriorityAsync(id);
            return Ok(priority);
        }
    }
}
