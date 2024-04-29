using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FlowCRM.Controllers
{
		[Route("api/[controller]")]
		[ApiController]
		public class ActivitiesTypeController : ControllerBase
		{
				private readonly IActivityTypeRepository _activityTypeRepository;

				public ActivitiesTypeController(IActivityTypeRepository activityTypeRepository)
				{
						_activityTypeRepository = activityTypeRepository;
				}

				// GET: api/ActivitiesType/All-ActivitiesType
				[HttpGet("All-ActivitiesType")]
				public async Task<ActionResult<IEnumerable<ActivityType>>> GetActivitiesTypeAsync()
				{
						var activitiesType = await _activityTypeRepository.GetActivitiesTypeAsync();
						return Ok(activitiesType);
				}

				// GET: api/ActivitiesType/Single-ActivityType/5
				[HttpGet("Single-ActivityType/{id}")]
				public async Task<ActionResult<ActivityType>> GetActivityTypeAsync(Guid id)
				{
						var activityType = await _activityTypeRepository.GetActivityTypeAsync(id);
						return Ok(activityType);
				}
		}
}
