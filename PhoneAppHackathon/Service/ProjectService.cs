using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PhoneAppHackathon.Models;

namespace PhoneAppHackathon.Service
{
    public class ProjectService : BaseService
    {
        public async Task<IEnumerable<Project>> GetAll()
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "bmVvQHRoZU1hdHJpeC5uZXQ6TmVv");
            var request = new HttpRequestMessage(HttpMethod.Get, "api/Projects");
            var response = await _client.SendAsync(request);
            var jsonString = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrWhiteSpace(jsonString))
            {
                return JsonConvert.DeserializeObject<List<Project>>(jsonString);
            }
            return new List<Project>();
        }
    }
}
