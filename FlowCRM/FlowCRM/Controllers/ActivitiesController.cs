using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FlowCRM.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ActivitiesController : ControllerBase
	{
		private readonly IActivityRepository _activityRepository;

		public ActivitiesController(IActivityRepository activityRepository)
		{
			_activityRepository = activityRepository;
		}

		// GET: api/Activities/All-Activities
		[HttpGet("All-Activities")]
		public async Task<ActionResult<IEnumerable<Activity>>> GetActivities()
		{
			var activities = await _activityRepository.GetActivitiesAsync();
			return Ok(activities);
		}

		// GET: api/Activities/Single-Activity/5
		[HttpGet("Single-Activity/{id}")]
		public async Task<ActionResult<Activity>> GetActivity(Guid id)
		{
			var activity = await _activityRepository.GetActivityAsync(id);
			return Ok(activity);
		}

		// POST: api/Activities/Add-Activity
		[HttpPost("Add-Activity")]
		public async Task<ActionResult<Activity>> PostActivity(Activity activity)
		{
			string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			activity.CreatedBy = userId;

			var newActivity = await _activityRepository.AddActivityAsync(activity);
			return CreatedAtAction("GetActivity", new { id = newActivity.ActivityId }, newActivity);
		}

		// PUT: api/Activities/Update-Activity
		[HttpPut("Update-Activity")]
		public async Task<IActionResult> PutActivity(Activity activity)
		{
			string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			activity.UpdatedBy = userId;

			var updatedActivity = await _activityRepository.UpdateActivityAsync(activity);

			return Ok(updatedActivity);
		}


		// DELETE: api/Activities/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteActivity(Guid id)
		{
			var activity = await _activityRepository.DeleteActivityAsync(id);

			return Ok(activity);
		}
	}
}
