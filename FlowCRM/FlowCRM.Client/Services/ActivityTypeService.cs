using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using System.Net.Http.Json;

namespace FlowCRM.Client.Services
{
		public class ActivityTypeService : IActivityTypeRepository
		{
				private readonly HttpClient _httpClient;

				public ActivityTypeService(HttpClient httpClient)
				{
						_httpClient = httpClient;
				}

				public async Task<IEnumerable<ActivityType>> GetActivitiesTypeAsync()
				{
						var activitiesType = await _httpClient.GetAsync("api/ActivitiesType/All-ActivitiesType");
						var response = await activitiesType.Content.ReadFromJsonAsync<IEnumerable<ActivityType>>();

						if (response == null)
						{
								throw new Exception("Error getting activities type");
						}

						return response;
				}

				public async Task<ActivityType> GetActivityTypeAsync(Guid id)
				{
						var activityType = await _httpClient.GetAsync($"api/ActivitiesType/Single-ActivityType/{id}");
						var response = await activityType.Content.ReadFromJsonAsync<ActivityType>();

						if (response == null)
						{
								throw new Exception("Error getting activity type");
						}

						return response;
				}
		}
}
