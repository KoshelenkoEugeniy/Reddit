using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform;
using Newtonsoft.Json;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Data.Models;
using Reddit.Core.Helpers.Interfaces;
using Reddit.Core.Managers;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Services
{
    public class RedditApi : IRedditApi
    {
        public const string BaseAddress = GlobalConstants.Api.OauthBaseAddress;

        protected readonly IDeviceInfo DeviceInfo;

        private HttpClient _client;


        public RedditApi()
        {
            DeviceInfo = Mvx.Resolve<IDeviceInfo>();
            CreateClient();
        }

        public async Task<UserResponseDto> GetCurrentUser(AccessResponseDto token)
        {
            if (token.access_token == null || token.token_type == null)
                return null;

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token.token_type, token.access_token);
            var response = await _client.GetAsync($"{BaseAddress}/api/v1/me");             var strResponse = await response?.Content.ReadAsStringAsync(); 
            return response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<UserResponseDto>(strResponse) : null;
        }

        public async Task<HomeResponseDto> GetUserHomeFeeds()
        {             var response = await _client.GetAsync($"{BaseAddress}/.json");             var strResponse = await response?.Content.ReadAsStringAsync(); 
            return response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<HomeResponseDto>(strResponse) : null;
        }

        private void CreateClient()
        {
            //var token = AccountManager.GetTokenInfo();
            _client = new HttpClient();
            _client.BaseAddress = new Uri(BaseAddress);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(("application/json")));
            if(DeviceInfo.DeviceType == "iOS")
            {
                _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("iOSReddit", "1.0"));
            }
            else
            {
                _client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("DroidReddit", "1.0"));
            }
            //_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token.token_type, token.access_token);
        }
    }
}
