using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Services
{
    public class AccountService: BaseService, IAccountService
    {
        public async Task<AccessResponseDto> GetAccessToken(string userName, string password)
        {
            var url = $"{GlobalConstants.Api.AuthAddress}/api/v1/access_token?grant_type=password&username={userName}&password={password}";
            var byteArray = Encoding.UTF8.GetBytes($"{GlobalConstants.RedditApp.AppId}:{GlobalConstants.RedditApp.AppSecret}");

            var _authClient = new HttpClient();
            _authClient.DefaultRequestHeaders.Accept.Clear();
            _authClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _authClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("basic", Convert.ToBase64String(byteArray));

            var response = await _authClient.PostAsync(url, null);
            var strResponse = await response?.Content.ReadAsStringAsync();

            return response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<AccessResponseDto>(strResponse) : null;
        }

        public async Task<UserResponseDto> GetUser(AccessResponseDto token)
        {
            var result = await ApiService.Client.GetCurrentUser(token);
            return result;
        }
    }
}
