using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Data.Models;
using Reddit.Core.Managers;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Services
{
    public class RedditApi : IRedditApi
    {
        public const string BaseAddress = GlobalConstants.Api.OauthBaseAddress;

        private HttpClient _client;


        public RedditApi()
        {
            CreateClient();
        }

        public async Task<UserResponseDto> GetCurrentUser(AccessResponseDto token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token.token_type, token.access_token);
            var response = await _client.GetAsync($"{BaseAddress}/api/v1/me");             var strResponse = await response?.Content.ReadAsStringAsync(); 
            return response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<UserResponseDto>(strResponse) : null;
        }

        private void CreateClient()
        {
            //var token = AccountManager.GetTokenInfo();
            _client = new HttpClient();
            _client.BaseAddress = new Uri(BaseAddress);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(("application/json")));
            //_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token.token_type, token.access_token);
        }
    }
}
