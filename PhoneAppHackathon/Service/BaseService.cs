using System;
using System.Net.Http;
using PhoneAppHackathon.Models;

namespace PhoneAppHackathon.Service
{
    public class BaseService
    {
        protected static User _currentUser;
        protected HttpClient _client = new HttpClient();

        public BaseService()
        {
            _client.BaseAddress = _client.BaseAddress ?? new Uri("https://thematrixrevolutions.azurewebsites.net/");
        }
    }
}
