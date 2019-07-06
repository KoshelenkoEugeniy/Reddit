using System;
using System.Net.Http;
using Reddit.Core.Services.Interfaces;
using Refit;

namespace Reddit.Core.Services
{
    public class ApiService: IApiService
    { 
        public const string BaseAddress = GlobalConstants.Api.OauthBaseAddress;          private readonly Lazy<IRedditApi> _client;

        public IRedditApi Client         {
            get             {
                return _client.Value;
            }
        }

        public ApiService()         {
            _client = new Lazy<IRedditApi>(CreateClient);
        }

        private IRedditApi CreateClient()
        {
            var httpClient = new HttpClient() //(new AuthenticatedHttpClientHandler(AccountManager.GetToken))
            {
                BaseAddress = new Uri(BaseAddress)
            };

            return RestService.For<IRedditApi>(httpClient);
        }
    }
}
