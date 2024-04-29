using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using System.Net.Http.Json;

namespace FlowCRM.Client.Services
{
	public class ActivityService : IActivityRepository
	{
		private readonly HttpClient _httpClient;

		public ActivityService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<IEnumerable<Activity>> GetActivitiesAsync()
		{
			var activities = await _httpClient.GetAsync("api/Activities/All-Activities");
			var response = await activities.Content.ReadFromJsonAsync<IEnumerable<Activity>>();

			if (response == null)
			{
				throw new Exception("Error getting activities");
			}

			return response;
		}

		public async Task<Activity> GetActivityAsync(Guid id)
		{
			var activity = await _httpClient.GetAsync($"api/Activities/Single-Activity/{id}");
			var response = await activity.Content.ReadFromJsonAsync<Activity>();

			if (response == null)
			{
				throw new Exception("Error getting activity");
			}

			return response;
		}

		public async Task<Activity> AddActivityAsync(Activity activity)
		{
			var newActivity = await _httpClient.PostAsJsonAsync("api/Activities/Add-Activity", activity);
			var response = await newActivity.Content.ReadFromJsonAsync<Activity>();

			if (response == null)
			{
				throw new Exception("Error creating new activity");
			}

			return response;
		}
		public async Task<Activity> UpdateActivityAsync(Activity activity)
		{
			var updatedActivity = await _httpClient.PutAsJsonAsync("api/Activities/Update-Activity", activity);
			var response = await updatedActivity.Content.ReadFromJsonAsync<Activity>();

			if (response == null)
			{
				throw new Exception("Error updating activity");
			}

			return response;
		}

		public async Task<Activity> DeleteActivityAsync(Guid id)
		{
			var activity = await _httpClient.DeleteAsync($"api/Activities/{id}");
			var response = await activity.Content.ReadFromJsonAsync<Activity>();

			if (response == null)
			{
				throw new Exception("Error deleting activity");
			}

			return response;
		}

	}
}
